using NUnit.Framework;

namespace GameOfLife {
    [TestFixture]
    public class GameOfLifeTests {
        [Test]
        public void TestDeadCellWith0NeighboursStaysDeadInNextGeneration() {
            ICell cell = new DeadCell();
            cell = cell.NextGeneration(0);
            Assert.True(cell is DeadCell);
        }

        [Test]
        public void TestLiveCellWith0NeighboursDiesInNextGeneration() {
            ICell cell = new LiveCell();
            cell = cell.NextGeneration(0);
            Assert.True(cell is DeadCell);
        }

        [Test]
        public void TestLiveCellWith1NeighboursDiesInNextGeneration() {
            ICell cell = new LiveCell();
            cell = cell.NextGeneration(1);
            Assert.True(cell is DeadCell);
        }

        [Test]
        public void TestLiveCellWith4NeighboursDiesInNextGeneration() {
            ICell cell = new LiveCell();
            cell = cell.NextGeneration(4);
            Assert.True(cell is DeadCell);
        }
        [Test]
        public void TestLiveCellWith2NeighboursLivesTheNextGeneration() {
            ICell cell = new LiveCell();
            cell = cell.NextGeneration(2);
            Assert.True(cell is LiveCell);
        }
        [Test]
        public void TestLiveCellWith3NeighboursLivesInNextGeneration() {
            ICell cell = new LiveCell();
            cell = cell.NextGeneration(3);
            Assert.True(cell is LiveCell);
        }
        
        [Test]
        public void TestDeadCellWithExactly3NeighboursLivesInNextGeneration() {
            ICell cell = new DeadCell();
            cell = cell.NextGeneration(3);
            Assert.True(cell is LiveCell);
        }        
        [Test]
        public void TestDeadCellWithExactly5NeighboursStaysDeadInNextGeneration() {
            ICell cell = new DeadCell();
            cell = cell.NextGeneration(3);
            Assert.True(cell is LiveCell);
        }
    }
}