using System;
using System.Collections.Generic;
using System.Text;
using ProcessAutomationTest.Abstracts;

namespace ProcessAutomationTest.Chains
{
    class Chain1 : AbstractProcessAutomation
    {
        public Chain1()
        {
            var ProcessStart = new Processes.ProcessStart();
            var ProcessA = new Processes.ProcessA();
            var ProcessB = new Processes.ProcessB();
            var ProcessC = new Processes.ProcessC();
            var processEnd = new Processes.ProcessEnd();

            SetChainMap(ProcessStart, new List<Interfaces.IProcessHandler> { ProcessA, ProcessB, ProcessC }, processEnd);
        }

        public override void RunChain()
        {
            base.RunChain();
        }
    }
}
