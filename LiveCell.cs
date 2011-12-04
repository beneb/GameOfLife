namespace GameOfLife {
    public class LiveCell : ICell {
        public ICell NextGeneration(int liveNighbours) {
            if (liveNighbours < 2 || liveNighbours > 3) {
                return new DeadCell();
            }
            return this;
        }
    }
}