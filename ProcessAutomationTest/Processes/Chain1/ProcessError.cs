using ProcessAutomationTest.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain1
{
    class ProcessError : AbstractProcessHandler
    {
        public override void Execute()
        {
            Console.WriteLine($"Error occured. Rollback.\n");
        }
    }
}
