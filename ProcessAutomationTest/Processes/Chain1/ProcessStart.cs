using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain1
{
    class ProcessStart : AbstractProcessHandler, IProcessStart
    {
        public override void Execute(ref object payload)
        {
            Console.WriteLine($"Start chain 1.\n");
        }
    }
}
