using Minesweeper.Core;
using Minesweeper.Core.Enums;
using Minesweeper.Core.Models;
using NUnit.Framework;

namespace MineSweeper.PositiveUnitTests
{
    [TestFixture]
    public class OpenMethodTests
    {
        /* _gameProcessor is a reference to an instance of the Minesweeper.Core class */
        private GameProcessor _gameProcessor;
        /* boolean array that stores the state of the cells */
        private bool[,] _field;

        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void PostCondition()
        {
        }

        /* this test method ensures that the Open method behaves correctly under different scenarios */
        [Test]
        /* define five arguments as data input for each test cases */
        /* cordinate x - cordinate y - rows - columns - mines quantity */
        [TestCase(0, 0, 5, 5, 0)]
        [TestCase(5, 5, 10, 10, 5)]
        [TestCase(10, 10, 20, 20, 10)]
        [TestCase(10, 10, 20, 20, 20)]

        public void T1_RandomFieldGenerator_OpenCell_GameStateObjectIsInstanceOfGameProcessor(int x, int y, int row, int column, int mines)
        {
            /* precondition */
            _field = FieldGenerator.GetRandomField(row, column, mines);

            /* action */
            _gameProcessor = new GameProcessor(_field);

            /* assert */
            Assert.IsInstanceOf<GameState>(_gameProcessor.Open(x, y));
        }

        [Test]
        [TestCase(5, 5, GameState.Win, 10, 10, 0)]
        [TestCase(10, 10, GameState.Lose, 20, 20, 400)]
        public void T2_RandomFieldGenerator_OpenCell_ReturnGameState(int x, int y, GameState gameStateExpected, int row, int column, int mines)
        {
            /* precondition */
            _field = FieldGenerator.GetRandomField(row, column, mines);
            _gameProcessor = new GameProcessor(_field);

            /* action */
            GameState gameState = _gameProcessor.Open(x, y);

            /* assert */
            Assert.AreEqual(gameState, gameStateExpected);
        }

        [Test]
        [TestCase(5, 5, 10, 10, 0)] /*open cell after win */
        [TestCase(10, 10, 20, 20, 400)] /* open cell after lose */
        public void T3_RandomFieldGenerator_OpenCellAfterWinAndLose_ThrowException(int x, int y, int row, int column, int mines)
        {
            /* precondition */
            _field = FieldGenerator.GetRandomField(row, column, mines);
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.Throws<InvalidOperationException>(() => _gameProcessor.Open(x, y));
        }
    }
}
