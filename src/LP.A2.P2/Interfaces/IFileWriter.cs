using System.Collections.Generic;

namespace LP.A2.P2.Interfaces
{
    public interface IFileWriter
    {
        void WriteLines(IEnumerable<string> lines, string outPath);
    }
}
