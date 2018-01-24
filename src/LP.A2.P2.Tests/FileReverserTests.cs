using System;
using System.Collections.Generic;
using LP.A2.P2.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LP.A2.P2.Tests
{
    [TestClass]
    public class FileReverserTests
    {
        [TestMethod]
        [Description("The FileReader ReadLines method should be called once, using filePath as the argument")]
        public void Reverser_Should_Use_The_FileReader()
        {
            //Arrange

            var filePath = "This is a mock file path";

            var readerMock = new Mock<IFileReader>();
            var writerMock = new Mock<IFileWriter>();
            var logicMock = new Mock<IReversalLogic>();

            var sut = new FileReverser(readerMock.Object, writerMock.Object, logicMock.Object);

            //Act

            sut.Reverse(filePath, "outPath");

            //Assert

            readerMock.Verify(x => x.ReadLines(filePath), Times.Once);


        }

        [TestMethod]
        [Description("The ReversalLogic Reverse method should be called once, with the result of the FileReader ReadLines method as the argument")]
        public void Reverser_Should_Use_The_ReversalLogic()
        {
            //Arrange

            var lines = new List<string>();

            var readerMock = new Mock<IFileReader>();
            readerMock.Setup(x => x.ReadLines(It.IsAny<string>())).Returns(lines);

            var writerMock = new Mock<IFileWriter>();
            var logicMock = new Mock<IReversalLogic>();

            var sut = new FileReverser(readerMock.Object, writerMock.Object, logicMock.Object);

            //Act

            sut.Reverse("inPath", "outPath");

            //Assert

            logicMock.Verify(x => x.Reverse(lines), Times.Once);
        }

        [TestMethod]
        [Description("The FileWriter write method should be called once, with the result of the ReversalLogic Reverse method and the outPath as the file as the arguments")]
        public void Reverser_Should_Use_The_FileWriter()
        {
            //Arrange

            var outPath = "This is a mock output path";

            var reveresedLines = new List<string>();

            var readerMock = new Mock<IFileReader>();
            var writerMock = new Mock<IFileWriter>();

            var logicMock = new Mock<IReversalLogic>();
            logicMock.Setup(x => x.Reverse(It.IsAny<List<string>>())).Returns(reveresedLines);

            var sut = new FileReverser(readerMock.Object, writerMock.Object, logicMock.Object);

            //Act

            sut.Reverse("inPath", outPath);

            //Assert

            writerMock.Verify(x => x.WriteLines(reveresedLines, outPath), Times.Once);

        }

    }
}
