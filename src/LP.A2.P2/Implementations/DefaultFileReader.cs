using System.Collections.Generic;
using System.IO;
using LP.A2.P2.Interfaces;

namespace LP.A2.P2.Implementations
{
    public class DefaultFileReader : IFileReader
    {
        public IEnumerable<string> ReadLines(string filePath)
        {
            return File.ReadLines(filePath);
        }
    }
}
