using ProcessAutomationTest.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes
{
    class ProcessA : AbstractProcessHandler
    {    
        public override void Execute()
        {
            Console.WriteLine($"Done executing ProcessA.\n");
        }
    }
}
