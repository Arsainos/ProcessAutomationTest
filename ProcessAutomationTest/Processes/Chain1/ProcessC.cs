using ProcessAutomationTest.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain1
{
    class ProcessC : AbstractProcessHandler
    {
        public override void Execute(ref object payload)
        {
            Console.WriteLine($"Done executing ProcessC.\n");
        }
    }
}
