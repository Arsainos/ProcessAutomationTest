using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain1
{
    class ProcessError : AbstractProcessHandler<AutomationChainShareObject>
    {
        public override void Execute(AutomationChainShareObject payload)
        {

            Console.WriteLine($"Error occured. Rollback.\n");
        }
    }
}
