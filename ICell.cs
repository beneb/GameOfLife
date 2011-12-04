namespace GameOfLife {
    public interface ICell {
        ICell NextGeneration(int liveNeighbors);
    }
}