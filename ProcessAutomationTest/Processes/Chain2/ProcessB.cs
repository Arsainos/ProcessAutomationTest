using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain2
{
    class ProcessB : AbstractProcessHandler
    {
        public override void Execute(ref AutomationChainShareObject payload)
        {
            payload.Message += "10";

            Console.WriteLine(payload.Message);

            IProcessAutomation processAutomation = new Chains.Chain1(payload);
            processAutomation.RunChain();

            Console.WriteLine($"Done executing ProcessB.\n");
        }
    }
}
