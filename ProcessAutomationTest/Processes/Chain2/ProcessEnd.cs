using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain2
{
    class ProcessEnd : AbstractProcessHandler, IProcessEnd
    {
        public override void Execute(ref AutomationChainShareObject payload)
        {
            Console.WriteLine($"End chain 2.\n");
        }
    }
}
