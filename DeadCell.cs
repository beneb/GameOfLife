namespace GameOfLife {
    public class DeadCell : ICell {
        public ICell NextGeneration(int liveNeighbors) {
            if (liveNeighbors == 3) {
                return new LiveCell();
            }
            return this;
        }
    }
}