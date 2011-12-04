namespace GameOfLife {
    public class DeadCell : ICell {
        public ICell NextGeneration(int liveNighbours) {
            if (liveNighbours == 3) {
                return new LiveCell();
            }
            return this;
        }
    }
}