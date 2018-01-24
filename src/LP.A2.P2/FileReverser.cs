using System.IO;
using LP.A2.P2.Interfaces;

namespace LP.A2.P2
{
   public class FileReverser
    {
        private readonly IFileReader _reader;
        private readonly IFileWriter _wrtier;
        private readonly IReversalLogic _logic;

        public FileReverser(IFileReader reader, IFileWriter wrtier, IReversalLogic logic)
        {
            _reader = reader;
            _wrtier = wrtier;
            _logic = logic;
        }

        public FileInfo Reverse(string filePath, string outPath)
        {
            var lines = _reader.ReadLines(filePath);
            var reveresed = _logic.Reverse(lines);

            _wrtier.WriteLines(reveresed, outPath);

            return new FileInfo(outPath);

        }

    }
}
