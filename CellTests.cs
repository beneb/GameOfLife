using NUnit.Framework;

namespace GameOfLife {
    [TestFixture]
    public class GameOfLifeTests {
        [Test]
        public void TestDeadCellWith0NeighborsStaysDeadInNextGeneration() {
            ICell cell = new DeadCell();
            cell = cell.NextGeneration(0);
            Assert.True(cell is DeadCell);
        }

        [Test]
        public void TestLiveCellWith0NeighborsDiesInNextGeneration() {
            ICell cell = new LiveCell();
            cell = cell.NextGeneration(0);
            Assert.True(cell is DeadCell);
        }

        [Test]
        public void TestLiveCellWith1NeighborsDiesInNextGeneration() {
            ICell cell = new LiveCell();
            cell = cell.NextGeneration(1);
            Assert.True(cell is DeadCell);
        }

        [Test]
        public void TestLiveCellWith4NeighborsDiesInNextGeneration() {
            ICell cell = new LiveCell();
            cell = cell.NextGeneration(4);
            Assert.True(cell is DeadCell);
        }
        [Test]
        public void TestLiveCellWith2NeighborsLivesTheNextGeneration() {
            ICell cell = new LiveCell();
            cell = cell.NextGeneration(2);
            Assert.True(cell is LiveCell);
        }
        [Test]
        public void TestLiveCellWith3NeighborsLivesInNextGeneration() {
            ICell cell = new LiveCell();
            cell = cell.NextGeneration(3);
            Assert.True(cell is LiveCell);
        }
        
        [Test]
        public void TestDeadCellWithExactly3NeighborsLivesInNextGeneration() {
            ICell cell = new DeadCell();
            cell = cell.NextGeneration(3);
            Assert.True(cell is LiveCell);
        }        
        [Test]
        public void TestDeadCellWithExactly5NeighborsStaysDeadInNextGeneration() {
            ICell cell = new DeadCell();
            cell = cell.NextGeneration(3);
            Assert.True(cell is LiveCell);
        }
    }
}