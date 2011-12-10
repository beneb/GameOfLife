using System;
using System.Collections.Generic;

namespace GameOfLife {
    public class World2D {
        private readonly int _xSize;
        private readonly int _ySize;

        private IEnumerable<ICell> _population;
        private int[,] _world;

        public World2D(int xSize, int ySize) {
            _xSize = xSize;
            _ySize = ySize;
            _world = new int[_xSize,_ySize];
        }

        public void NextGneration() {
            foreach (ICell cell in _population) {
                cell.NextGeneration(GetNeighboursCount(cell));
            }
        }

        private int GetNeighboursCount(ICell cell) {
            throw new NotImplementedException();
        }
    }
}