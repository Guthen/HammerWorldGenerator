
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

public class Chunk2D
{

    static int seed = 0;
    static int cellSize = 8;
    static int chunkW = 600;
    static int chunkH = 800;
    static int surfaceY = 30;
    static int minSurfaceY = chunkH / cellSize - 15;
    static int maxSurfaceY = 5;
    static int[] fillIDs = { 1, 2 };

    Random random = new Random(seed);

    /*
	    --  > get config
    */

    public int getSeed() {
        return seed;
    }

    public int getCellSize() {
        return cellSize;
    }

    public int getChunkSize() {
        return chunkW; chunkH;
    }

    public int getSurfaceValues() {
        return surfaceY; minSurfaceY; maxSurfaceY;
    }

    public int getFillSurfaces() {
        return fillIDs;
    }

    /*
	    --  > config
    */

    public void set(int _seed, int _cellSize, int _chunkW, int _chunkH, int _startY, int _minY, int _maxY) {

        seed = _seed | seed;
        cellSize = _cellSize | cellSize;

        chunkW = _chunkW | chunkW;
        chunkH = _chunkH | chunkH;

        surfaceY = _startY | surfaceY;
        minSurfaceY = _minY | minSurfaceY;

        maxSurfaceY = _maxY | maxSurfaceY;

        if (_seed) {
            random = new Random(seed);
        }
    }

    public void setFillID(int[] _IDs) {
        fillIDs = _IDs | fillIDs;
    }

    /*
	    --  > chunks & world
    */

    //  > Create Empty Chunk
    public int createEmptyChunk() {
        int[,] _chunk = {};
        for ( int y = 0; y <= chunkH / cellSize; y++ ) {
            _chunk[y] = new int[];
            for ( int x = 0; x <= chunkW / cellSize; x++ ) {
                _chunk[y,x] = 0;
            }
        }
        return _chunk;
    }

    //  > Get SurfaceY Position of the '_chunk' by given '_x' 
    public int getSurfaceY( int[] _chunk, int _x ) {
        if (_x < 0) return;
        int y = 0;
        foreach ( int yv in _chunk ) {
            int x = 0;
            foreach ( int xv in yv ) {
                if ( _x == x ) {
                    if ( xv > 0 ) return y;
                }
                x++;
            }
            y++;
        }
    }

    //  > Create & Generate a chunk by using the '_lastChunk'
    public int generateChunk( ref int[] _chunk, ref int[] _lastChunk ) { 

        void fillChunk() { 
		    for ( int x = 0; x <= chunkW/cellSize; x++ ) {
                var y = getSurfaceY(_chunk, x);

			    if ( y ) {

                    var b = 0;
                    var surface = fillIDs[1];
				    for ( _y = y+1; H/cellSize; _y++ ) {
                        _chunk[_y][x] = surface;
                        b = b + 1;
		 			    if ( b > 0 && fillIDs[b] ) {
                            surface = fillIDs[b];
                        }
                     }

                 }
            }
        }

	    for ( x = 0; x <= chunkW/cellSize; x++ ) { // generate the surface

            var _y;
            if (_lastChunk && x == 1) {
                _y = getSurfaceY(_lastChunk, chunkW / cellSize);
            }
            else {
                _y = getSurfaceY(_chunk, x - 1);
            }

		    if ( _y ) {
                int offset = random.Next(-1, 1); // get the Y offset
                if (_chunk[_y + offset] && _chunk[_y + offset][x]) { // if it's exists
                    if (_y + offset < maxSurfaceY | _y + offset > minSurfaceY)
                    {
                        offset = 0;
                    }
                    _chunk[_y + offset][x] = fillIDs[1];
                }
            }
            else if ( _lastChunk == null ) {
                _chunk[surfaceY][x] = fillIDs[1];
            }

        }

        smoothChunk(_chunk, _lastChunk);
        fillChunk();
    }

    //  > Create & Generate a world of 'nChunks' chunks
    public int generateWorld( int nChunks ) {
        int[] world = {};
	    for ( int i = 1; i <= nChunks; i++ ) {
            world[i] = createEmptyChunk();

            generateChunk( world[i], world[i - 1] );
        }
        return world;
    }

    //  > Smooth the chunk
    public void smoothChunk( ref int[] _chunk, ref int[] _lastChunk ) {
        for ( int x = 0; x <= chunkW / cellSize; x++) { // smoothness

            var activeChunk = _chunk;

            var y, _y, __y, ___y;
            y = getSurfaceY(_chunk, x);

            if (_lastChunk && _chunk[x - 1] == null) {
                _y = getSurfaceY(_lastChunk, chunkW / cellSize - 1);

                activeChunk = _lastChunk;
            }
            else {
                _y = getSurfaceY(_chunk, x - 1);
            }
            if (_lastChunk && _chunk[x - 2] == null) {
                __y = getSurfaceY(_lastChunk, chunkW / cellSize - 2);

                activeChunk = _lastChunk;
            }
            else { 
                __y = getSurfaceY(_chunk, x - 2);
            }
            if (_lastChunk && _chunk[x - 3] == null) {
                ___y = getSurfaceY(_lastChunk, chunkW / cellSize - 3);

                activeChunk = _lastChunk;
            }
            else {
                ___y = getSurfaceY(_chunk, x - 3);
            }

		    if ( y && _y && __y ) {
                if (y == __y && (_y != y) && Abs(y - _y) <= 1 && activeChunk[y]) { // if : '0 - 1 - 0' or : '1 - 0 - 1'
                    if (_y && y && _y < y) { activeChunk[_y][x - 1] = 0; }

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
    public void smoothWorld( ref int[] world ) {
        for ( int id = 1; world.Length; id++ ) { 
		    int[] curChunk = world[id];
            int[] lastChunk = world[id - 1];

            smoothChunk( curChunk, lastChunk );
        }
    }
}