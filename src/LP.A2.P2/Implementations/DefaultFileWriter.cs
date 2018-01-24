using System.Collections.Generic;
using System.IO;
using LP.A2.P2.Interfaces;

namespace LP.A2.P2.Implementations
{
    public class DefaultFileWriter : IFileWriter
    {
        public void WriteLines(IEnumerable<string> lines, string outPath)
        {
            if (File.Exists(outPath))
                File.Delete(outPath);

            File.WriteAllLines(outPath, lines);
        }
    }
}
