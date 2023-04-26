using Minesweeper.Core;
using Minesweeper.Core.Enums;
using Minesweeper.Core.Models;
using NUnit.Framework;
using System.Data.Common;
using System.Xml.Linq;

/* ################################################################ */
/* the code would be better if a field generator class were created */
/* ################################################################ */

namespace MineSweeper.PositiveUnitTests
{
    [TestFixture]
    public class GetCurrentFieldTests
    {
        private GameProcessor _gameProcessor;
        private bool[,] _field;
        private PointState[,] _pointState;


        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void PostCondition()
        {
        }

        [Test]
        [TestCase(1, 1)]
        /* open cell without mines and neighbours and the result must be the same as _pointState  */
        public void T01_FieldGenerated_OpenCellWithoutNeighbors_ReturnExpectedPointState(int x, int y)
        {
            /* precondition */
            _field = new bool[,]
            {
                { false, false, false },
                { false, false, false },
                { false, false, false }
            };
            _pointState = new PointState[,]
            {
                { PointState.Neighbors0, PointState.Neighbors0, PointState.Neighbors0 },
                { PointState.Neighbors0, PointState.Neighbors0, PointState.Neighbors0 },
                { PointState.Neighbors0, PointState.Neighbors0, PointState.Neighbors0 }
            };
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.That(_gameProcessor.GetCurrentField(), Is.EqualTo(_pointState));
        }

        [Test]
        [TestCase(1, 1)]
        /* open cell with no mines and 1 neighbour and the result must be the same as _pointState  */
        public void T02_FieldGenerated_OpenCellWithOneNeighbor_ReturnExpectedPointState(int x, int y)
        {
            /* precondition */
            _field = new bool[,]
            {
                { true, false, false },
                { false, false, false },
                { false, false, false }
            };
            _pointState = new PointState[,]
            {
                { PointState.Close, PointState.Close, PointState.Close },
                { PointState.Close, PointState.Neighbors1, PointState.Close },
                { PointState.Close, PointState.Close, PointState.Close }
            };
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.That(_gameProcessor.GetCurrentField(), Is.EqualTo(_pointState));
        }

        [Test]
        [TestCase(1, 1)]
        /* open cell with no mines and 2 neighbours and the result must be the same as _pointState  */
        public void T03_FieldGenerated_OpenCellWithTwoNeighbors_ReturnExpectedPointState(int x, int y)
        {
            /* precondition */
            _field = new bool[,]
            {
                { true, true, false },
                { false, false, false },
                { false, false, false }
            };
            _pointState = new PointState[,]
            {
                { PointState.Close, PointState.Close, PointState.Close },
                { PointState.Close, PointState.Neighbors2, PointState.Close },
                { PointState.Close, PointState.Close, PointState.Close }
            };
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.That(_gameProcessor.GetCurrentField(), Is.EqualTo(_pointState));
        }

        [Test]
        [TestCase(1, 1)]
        /* open cell with no mines and 3 neighbours and the result must be the same as _pointState  */
        public void T04_FieldGenerated_OpenCellWithThreeNeighbors_ReturnExpectedPointState(int x, int y)
        {
            /* precondition */
            _field = new bool[,]
            {
                { true, true, true },
                { false, false, false },
                { false, false, false }
            };
            _pointState = new PointState[,]
            {
                { PointState.Close, PointState.Close, PointState.Close },
                { PointState.Close, PointState.Neighbors3, PointState.Close },
                { PointState.Close, PointState.Close, PointState.Close }
            };
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.That(_gameProcessor.GetCurrentField(), Is.EqualTo(_pointState));
        }

        [Test]
        [TestCase(1, 1)]
        /* open cell with no mines and 4 neighbours and the result must be the same as _pointState  */
        public void T05_FieldGenerated_OpenCellFourTreeNeighbors_ReturnExpectedPointState(int x, int y)
        {
            /* precondition */
            _field = new bool[,]
            {
                { true, true, true },
                { true, false, false },
                { false, false, false }
            };
            _pointState = new PointState[,]
            {
                { PointState.Close, PointState.Close, PointState.Close },
                { PointState.Close, PointState.Neighbors4, PointState.Close },
                { PointState.Close, PointState.Close, PointState.Close }
            };
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.That(_gameProcessor.GetCurrentField(), Is.EqualTo(_pointState));
        }

        [Test]
        [TestCase(1, 1)]
        /* open cell with no mines and 5 neighbours and the result must be the same as _pointState  */
        public void T06_FieldGenerated_OpenCellWithFiveNeighbors_ReturnExpectedPointState(int x, int y)
        {
            /* precondition */
            _field = new bool[,]
            {
                { true, true, true },
                { true, false, true },
                { false, false, false }
            };
            _pointState = new PointState[,]
            {
                { PointState.Close, PointState.Close, PointState.Close },
                { PointState.Close, PointState.Neighbors5, PointState.Close },
                { PointState.Close, PointState.Close, PointState.Close }
            };
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.That(_gameProcessor.GetCurrentField(), Is.EqualTo(_pointState));
        }

        [Test]
        [TestCase(1, 1)]
        /* open cell with no mines and 6 neighbours and the result must be the same as _pointState  */
        public void T07_FieldGenerated_OpenCellWithSixNeighbors_ReturnExpectedPointState(int x, int y)
        {
            /* precondition */
            _field = new bool[,]
            {
                { true, true, true },
                { true, false, true },
                { true, false, false }
            };
            _pointState = new PointState[,]
            {
                { PointState.Close, PointState.Close, PointState.Close },
                { PointState.Close, PointState.Neighbors6, PointState.Close },
                { PointState.Close, PointState.Close, PointState.Close }
            };
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.That(_gameProcessor.GetCurrentField(), Is.EqualTo(_pointState));
        }

        [Test]
        [TestCase(1, 1)]
        /* open cell with no mines and 7 neighbours and the result must be the same as _pointState  */
        public void T08_FieldGenerated_OpenCellWithSevenNeighbors_ReturnExpectedPointState(int x, int y)
        {
            /* precondition */
            _field = new bool[,]
            {
                { true, true, true },
                { true, false, true },
                { true, true, false }
            };
            _pointState = new PointState[,]
            {
                { PointState.Close, PointState.Close, PointState.Close },
                { PointState.Close, PointState.Neighbors7, PointState.Close },
                { PointState.Close, PointState.Close, PointState.Close }
            };
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.That(_gameProcessor.GetCurrentField(), Is.EqualTo(_pointState));
        }

        [Test]
        [TestCase(1, 1)]
        /* open cell with no mines and 8 neighbours and the result must be the same as _pointState  */
        public void T09_FieldGenerated_OpenCellWithEightNeighbors_ReturnExpectedPointState(int x, int y)
        {
            /* precondition */
            _field = new bool[,]
            {
                { true, true, true },
                { true, false, true },
                { true, true, true }
            };
            _pointState = new PointState[,]
            {
                { PointState.Mine, PointState.Mine, PointState.Mine },
                { PointState.Mine, PointState.Neighbors8, PointState.Mine },
                { PointState.Mine, PointState.Mine, PointState.Mine }
            };
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.That(_gameProcessor.GetCurrentField(), Is.EqualTo(_pointState));
        }

        [Test]
        [TestCase(1, 1)]
        /* open cell with mines and the result must be the same as _pointState  */
        public void T10_FieldGenerated_OpenCellWithMine_ReturnExpectedPointState(int x, int y)
        {
            /* precondition */
            _field = new bool[,]
            {
                { false, false, false },
                { false, true, false },
                { false, false, false }
            };
            _pointState = new PointState[,]
            {
                { PointState.Neighbors0, PointState.Neighbors0, PointState.Neighbors0 },
                { PointState.Neighbors0, PointState.Mine, PointState.Neighbors0 },
                { PointState.Neighbors0, PointState.Neighbors0, PointState.Neighbors0 }
            };
            _gameProcessor = new GameProcessor(_field);

            /* action */
            _gameProcessor.Open(x, y);

            /* assert */
            Assert.That(_gameProcessor.GetCurrentField(), Is.EqualTo(_pointState));
        }

    }
}
