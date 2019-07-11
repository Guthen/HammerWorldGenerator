
/*
	MIT License

	Copyright (c) 2019 Gu{

	Permission is hereby granted, free of charge, to any person obtaining a copy
	of this software and associated documentation files (the "Software"), to deal
	in the Software without restriction, including without limitation the rights
	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in all
	copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
	SOFTWARE.
*/

using System;

public static class Chunk3D
{

    static int seed = 0;
    static int cellSize = 8;
    static int chunkW = 600;
    static int chunkH = 800;
    static int surfaceY = 30;
    static int minSurfaceY = chunkH / cellSize - 15;
    static int maxSurfaceY = 5;
    static int[] fillIDs = { 1, 2 };

    static bool fill = true;

    static Random random = new Random(seed);

    private static bool isInRange(int[] array, int k)
    {
        return k <= array.Length && k >= 0;
    }
    private static bool chunkIsInRange( int[][] array, int k )
    {
        return k <= array.Length && k >= 0;
    }
    private static bool worldIsInRange(int[][][] array, int k)
    {
        return k <= array.Length && k >= 0;
    }

    /*
	    --  > get config
    */

    public static int getSeed() {
        return seed;
    }

    public static int getCellSize() {
        return cellSize;
    }

    public static int getChunkWidth() {
        return chunkW;
    }
    public static int getChunkHeight() {
        return chunkH;
    }

    public static int getSurfaceStartY() {
        return surfaceY;
    }
    public static int getSurfaceMinY() {
        return minSurfaceY;
    }
    public  static int getSurfaceMaxY() {
        return maxSurfaceY;
    }

    public static int[] getFillSurfaces() {
        return fillIDs;
    }

    /*
	    --  > config
    */

    public static void set(int _seed, int _cellSize, int _chunkW, int _chunkH, int _startY, int _minY, int _maxY) {
        seed = _seed;
        cellSize = _cellSize;

        chunkW = _chunkW;
        chunkH = _chunkH;

        surfaceY = _startY;
        minSurfaceY = _minY;

        maxSurfaceY = _maxY;

        if ( _seed >= 0 ) {
            random = new Random(seed);
        }
    }

    public static void setFill( bool state )
    {
        fill = state;
    }

    public static void setFillID(int[] _IDs) {
        fillIDs = _IDs;
    }

    /*
	    --  > chunks & world
    */

    //  > Create Empty Chunk
    public static int[][] createEmptyChunk() {
        int[][] _chunk = new int[chunkH][];
        for ( int y = 0; y < chunkH; y++ )
        {
            _chunk[y] = new int[chunkW];
            for ( int x = 0; x < chunkW; x++ )
            {
                _chunk[y][x] = 0;
            }
        }
        return _chunk;
    }

    //  > Get SurfaceY Position of the '_chunk' by given '_x' 
    public static int getSurfaceY( int[][] _chunk, int _x ) {
        if (_x < 0) return -1;

        for ( int y = 0; y < _chunk.Length; y++ ) {
            for ( int x = 0; x < _chunk[0].Length; y++ ) {
                if ( _x == x ) {
                    if ( chunkIsInRange( _chunk, y ) && isInRange( _chunk[y], x ) && _chunk[y][x] > 0 ) return y;
                }
                x++;
            }
            y++;
        }

        return -1;
    }

    //  > Fill the chunk
    public static void fillChunk( ref int[][] _chunk ) {
        if (!fill) return;
        for (int x = 0; x < chunkW; x++)
        {
            var y = getSurfaceY(_chunk, x);

            if ( y > 0 )
            {
                var b = 0;
                var surface = fillIDs[1];
                for ( int _y = y + 1; y < chunkH; _y++ )
                {
                    _chunk[_y][x] = surface;
                    b = b + 1;
                    if ( isInRange(fillIDs, b) && b > 0 && fillIDs[b] > 0 )
                    {
                        surface = fillIDs[b];
                    }
                }

            }
        }
    }

    //  > Create & Generate a chunk by using the '_lastChunk'
    public static void generateChunk( ref int[][] _chunk, ref int[][] _lastChunk ) { 

	    for ( int x = 0; x < chunkW; x++ ) { // generate the surface

            var _y = -1;
            if ( _lastChunk.Length > 0 && x == 1 ) {
                _y = getSurfaceY(_lastChunk, chunkW);
            }
            else {
                _y = getSurfaceY(_chunk, x - 1);
            }

		    if ( _y > -1 ) {
                int offset = random.Next(-1, 1); // get the Y offset
                if ( _chunk.Length <= _y + offset | _y + offset >= 0 && _chunk[_y + offset][x] > -1 ) { // if it's exists
                    if (_y + offset < maxSurfaceY | _y + offset > minSurfaceY)
                    {
                        offset = 0;
                    }
                    _chunk[_y + offset][x] = fillIDs[1];
                }
            }
            else if ( _lastChunk.Length <= 0 ) {
                _chunk[surfaceY][x] = fillIDs[1];
            }

        }

        smoothChunk( ref _chunk, ref _lastChunk);
        fillChunk( ref _chunk );
    }

    //  > Create & Generate a world of 'nChunks' chunks
    public static int[][][] generateWorld( int nChunks ) {
        int[][][] world = new int[nChunks][][];
	    for ( int i = 0; i < nChunks; i++ ) {
            world[i] = createEmptyChunk();
            var lastChunk = worldIsInRange( world, i - 1 ) ? world[i-1] : new int[0][];

            generateChunk( ref world[i], ref lastChunk );
        }
        return world;
    }

    //  > Smooth the chunk
    public static void smoothChunk( ref int[][] _chunk, ref int[][] _lastChunk ) {
        for ( int x = 0; x < chunkW; x++) { // smoothness

            var activeChunk = _chunk;

            var y = -1;
            var _y = -1;
            var __y = -1;
            var ___y = -1;
            y = getSurfaceY(_chunk, x);

            if ( _lastChunk.Length > 0 && chunkIsInRange( _chunk, x-1 )  ) {
                _y = getSurfaceY(_lastChunk, chunkW - 1);

                activeChunk = _lastChunk;
            }
            else {
                _y = getSurfaceY(_chunk, x - 1);
            }
            if ( _lastChunk.Length > 0 && chunkIsInRange( _chunk, x - 2 ) ) {
                __y = getSurfaceY(_lastChunk, chunkW - 2);

                activeChunk = _lastChunk;
            }
            else { 
                __y = getSurfaceY(_chunk, x - 2);
            }
            if ( _lastChunk.Length > 0 && chunkIsInRange( _chunk, x - 3 ) ) {
                ___y = getSurfaceY(_lastChunk, chunkW - 3);

                activeChunk = _lastChunk;
            }
            else {
                ___y = getSurfaceY(_chunk, x - 3);
            }

		    if ( y > -1 && _y > -1 && __y > -1 ) {
                if ( y == __y && (_y != y) && Math.Abs(y - _y) <= 1 && chunkIsInRange( activeChunk, y ) ) { // if : '0 - 1 - 0' or : '1 - 0 - 1'
                    if (_y > -1 && y > -1 && _y < y) { activeChunk[_y][x - 1] = 0; }

                    activeChunk[y][x - 1] = 1;
                }
                else if ( y == ___y && _y == __y && y != _y ) {
                    activeChunk[y][x - 1] = 2;

                    activeChunk[y][x - 2] = 2;
                }

            }

        }
    }

    // Smooth all of the world chunks
    public static void smoothWorld( ref int[][][] world ) {
        for ( int id = 1; id < world.Length; id++ ) { 
		    int[][] curChunk = world[id];
            int[][] lastChunk = world[id - 1];

            smoothChunk( ref curChunk, ref lastChunk );
        }
    }
}