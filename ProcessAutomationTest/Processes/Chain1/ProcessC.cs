using ProcessAutomationTest.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes
{
    class ProcessC : AbstractProcessHandler
    {
        public override void Execute()
        {
            Console.WriteLine($"Done executing ProcessC.\n");
        }
    }
}
