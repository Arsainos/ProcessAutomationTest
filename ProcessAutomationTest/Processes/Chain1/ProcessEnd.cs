using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain1
{
    class ProcessEnd : AbstractProcessHandler, IProcessEnd
    {
        public override void Execute(ref object payload)
        {
            Console.WriteLine($"Done chain 1.\n");
        }
    }
}
