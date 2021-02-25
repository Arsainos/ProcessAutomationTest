using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Interfaces
{
    public interface IProcessAutomation
    {
        void RunChain();
        void SetChainMap(IProcessStart start, List<IProcessHandler> handlers, IProcessEnd end);
    }
}
