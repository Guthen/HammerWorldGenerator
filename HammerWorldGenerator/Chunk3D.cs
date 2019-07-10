
/*
	MIT License

	Copyright (c) 2019 Guthen

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

public class Chunk2D
{

    private int seed = 0;
    private int cellSize = 8;
    private int chunkW = 600;
    private int chunkH = 800;
    private int surfaceY = 30;
    private int minSurfaceY = chunkH / cellSize - 15;
    private int maxSurfaceY = 5;
    private int[] fillIDs = { 1, 2 };

    var random = new Random(seed);

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

        int[] _chunk = {};
        for (y = 0; y <= chunkH / cellSize; y++) { 
            _chunk[y] = {};
            for (x = 0; x <= chunkW / cellSize, x++) {
                _chunk[y][x] = 0;
            };
        };
        return _chunk;
    }

    --  > Get SurfaceY Position of the '_chunk' by given '_x' 
    function getSurfaceY(_chunk, _x )
	    if _x< 0 then return end
	    for y, yv in pairs(_chunk ) do
		    for x, xv in pairs(yv ) do
			    if _x == x then
				    if xv > 0 then return y end

                end
            end

        end
    end

    --  > Create & Generate a chunk by using the '_lastChunk'
    function generateChunk(_chunk, _lastChunk )

        local function fillChunk()
		    for x = 0, chunkW/cellSize do
			    local y = getSurfaceY(_chunk, x)

			    if y then

                    local b = 0

                    local surface = fillIDs[2]
				    for _y = y+1, H/cellSize do 
	 				    _chunk[_y][x] = surface
                         b = b + 1
		 			    if b > 1 and fillIDs[b] then
                             surface = fillIDs[b]

                         end
                     end

                 end
            end

        end

	    for x = 0, chunkW/cellSize do -- generate the surface

            local _y
		    if _lastChunk and x == 1 then
                _y = getSurfaceY(_lastChunk, chunkW / cellSize)
		    else
			    _y = getSurfaceY(_chunk, x-1 )

            end

		    if _y then

                local offset = math.random(-1, 1)-- get the Y offset
			    if _chunk[_y + offset] and _chunk[_y + offset][x] then -- if it's exists
				    if _y + offset<maxSurfaceY or _y + offset> minSurfaceY then
                     offset = 0

                    end
                    _chunk[_y + offset][x] = fillIDs[1]
    end

            elseif not _lastChunk then

                _chunk[surfaceY][x] = fillIDs[1]
            end


        end

        smoothChunk(_chunk, _lastChunk )

        fillChunk()
    end

    --  > Create & Generate a world of 'nChunks' chunks
    function generateWorld(nChunks )

        local world = { }
	    for i = 1, nChunks do
		    world[i] = createEmptyChunk()

            generateChunk(world[i], world[i - 1] )

        end
	    return world
    end

    --  > Smooth the chunk
    function smoothChunk(_chunk, _lastChunk )
	    for x = 0, chunkW/cellSize do -- smoothness

            local activeChunk = _chunk

            local y, _y, __y, ___y
            y = getSurfaceY(_chunk, x)

		    if _lastChunk and not _chunk[x - 1] then
                  _y = getSurfaceY(_lastChunk, chunkW / cellSize - 1)

                activeChunk = _lastChunk
		    else
			    _y = getSurfaceY(_chunk, x-1 )

            end
		    if _lastChunk and not _chunk[x - 2] then
                  __y = getSurfaceY(_lastChunk, chunkW / cellSize - 2)

                activeChunk = _lastChunk
		    else
			    __y = getSurfaceY(_chunk, x-2 )

            end
		    if _lastChunk and not _chunk[x - 3] then
                  ___y = getSurfaceY(_lastChunk, chunkW / cellSize - 3)

                activeChunk = _lastChunk
		    else
			    ___y = getSurfaceY(_chunk, x-3 )

            end

		    if y and _y and __y then
			    if y == __y and not(_y == y) and math.abs(y - _y ) <= 1 and activeChunk[y] then -- if : '0 - 1 - 0' or : '1 - 0 - 1'
				    if _y and y and _y<y then activeChunk[_y][x - 1] = 0 end

                    activeChunk[y][x - 1] = 1

                elseif y == ___y and _y == __y and not y == _y then

                    activeChunk[y][x - 1] = 2

                    activeChunk[y][x - 2] = 2

                end

            end


        end
    end

    -- Smooth all of the world chunks
    function smoothWorld(world )
	    for id = 1, #world do -- smoothness
		    local curChunk = world[id]

            local lastChunk = world[id - 1]


            smoothChunk(curChunk, lastChunk )

        end
    end
}