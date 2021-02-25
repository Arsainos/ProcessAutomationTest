using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain2
{
    class ProcessStart : AbstractProcessHandler, IProcessStart
    {
        public override void Execute()
        {
            Console.WriteLine($"Start chain 2.\n");
        }
    }
}
