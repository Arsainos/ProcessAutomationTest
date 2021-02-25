using System;
using System.Collections.Generic;
using System.Text;
using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Processes.Chain1;

namespace ProcessAutomationTest.Chains
{
    class Chain1 : AbstractProcessAutomation
    {
        public Chain1()
        {
            var ProcessStart = new ProcessStart();
            var ProcessA = new ProcessA();
            var ProcessB = new ProcessB();
            var ProcessC = new ProcessC();
            var processEnd = new ProcessEnd();

            SetChainMap(ProcessStart, new List<Interfaces.IProcessHandler> { ProcessA, ProcessB, ProcessC }, processEnd);
        }
    }
}
