using System.Collections.Generic;
using System.Linq;
using LP.A2.P2.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LP.A2.P2.Tests
{
    [TestClass]
    public class ReveralLogicTests
    {
        [TestMethod]
        public void Reverse_Should_Return_The_Same_Number_Of_Lines()
        {
            //Arrange

            var lines = new List<string>
            {
                "A11111111111111111111",
                "22222222222222222222Z"
            };

            var sut = new ReversalLogic();

            //Act

            var results = sut.Reverse(lines);

            //Assert

            Assert.AreEqual(lines.Count, results.Count());
        }

        [TestMethod]
        public void LastChar_LastLine_Should_Equal_FirstChar_FirstLine()
        {
            //Arrange

            var lines = new List<string>
            {
                "A11111111111111111111",
                "22222222222222222222Z"
            };

            //First char first line
            var expected = 'A';

            var sut = new ReversalLogic();

            //Act

            var results = sut.Reverse(lines);

            //Assert

            var lastCharLastLine = results.Last().Last();

            Assert.AreEqual(expected, lastCharLastLine);

        }

        [TestMethod]
        public void LastChar_SecondLastLine_Should_Equal_FirstChar_SecondLine()
        {
            //Arrange

            var lines = new List<string>
            {
                "A111B",
                "C222D",
                "E333F",
                "G444H"
            };

            //First char second line
            var expected = 'C';

            var sut = new ReversalLogic();

            //Act

            var results = sut.Reverse(lines);

            //Assert

            var lastCharSecondLastLine = results.ElementAt(2).Last();

            Assert.AreEqual(expected, lastCharSecondLastLine);

        }

        [TestMethod]
        public void FirstChar_FirstLine_Should_Equal_LastChar_LastLine()
        {
            //Arrange

            var lines = new List<string>
            {
                "A111B",
                "C222D",
                "E333F",
                "G444H"
            };

            //Last char last line
            var expected = 'H';

            var sut = new ReversalLogic();

            //Act

            var results = sut.Reverse(lines);

            //Assert

            var firstCharFirstLine = results.First().First();

            Assert.AreEqual(expected, firstCharFirstLine);

        }

    }
}
