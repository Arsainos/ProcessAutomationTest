using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain2
{
    class ProcessB : AbstractProcessHandler
    {
        public override void Execute(ref object payload)
        {
            IProcessAutomation processAutomation = new Chains.Chain1(payload);
            processAutomation.RunChain();

            Console.WriteLine($"Done executing ProcessB.\n");
        }
    }
}
