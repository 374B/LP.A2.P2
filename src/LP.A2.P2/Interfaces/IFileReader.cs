using System.Collections.Generic;

namespace LP.A2.P2.Interfaces
{
    public interface IFileReader
    {
        IEnumerable<string> ReadLines(string filePath);
    }
}
