using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain1
{
    class ProcessError : AbstractProcessHandler
    {
        public override void Execute(ref AutomationChainShareObject payload)
        {

            Console.WriteLine($"Error occured. Rollback.\n");
        }
    }
}
