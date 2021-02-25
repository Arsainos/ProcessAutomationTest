using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain2
{
    class ProcessB : AbstractProcessHandler<AutomationChainShareObject>
    {
        public override void Execute(AutomationChainShareObject payload)
        {
            payload.Message += "10";

            Console.WriteLine(payload.Message);

            IProcessAutomation<AutomationChainShareObject> processAutomation = new Chains.Chain1();
            processAutomation.RunChain(payload);

            Console.WriteLine($"Done executing ProcessB.\n");
        }
    }
}
