namespace GameOfLife {
    public class LiveCell : ICell {
        public ICell NextGeneration(int liveNeighbors) {
            if (liveNeighbors < 2 || liveNeighbors > 3) {
                return new DeadCell();
            }
            return this;
        }
    }
}