using System;
using System.Collections.Generic;
using System.Linq;
using LP.A2.P2.Interfaces;

namespace LP.A2.P2.Implementations
{
   public  class ReversalLogic : IReversalLogic
    {
        public IEnumerable<string> Reverse(IEnumerable<string> lines)
        {
            var reversedLines = lines.Reverse().ToList();

            for (int i = 0; i < reversedLines.Count; i++)
            {
                var reversedLine = new string(reversedLines[i].Reverse().ToArray());
                reversedLines[i] = reversedLine;
            }

            return reversedLines;
        }
    }
}
