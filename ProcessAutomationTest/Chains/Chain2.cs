using System;
using System.Collections.Generic;
using System.Text;
using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Processes.Chain2;

namespace ProcessAutomationTest.Chains
{
    class Chain2 : AbstractProcessAutomation
    {
        public Chain2()
        {
            var ProcessStart = new ProcessStart();
            var ProcessA = new ProcessA();
            var ProcessB = new ProcessB();
            var processEnd = new ProcessEnd();

            SetChainMap(ProcessStart, new List<Interfaces.IProcessHandler> { ProcessA, ProcessB }, processEnd);
        }
    }
    
}
