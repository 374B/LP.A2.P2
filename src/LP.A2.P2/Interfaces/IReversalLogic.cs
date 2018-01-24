using System.Collections.Generic;

namespace LP.A2.P2.Interfaces
{
    public interface IReversalLogic
    {
        IEnumerable<string> Reverse(IEnumerable<string> lines);
    }
}
