using ProcessAutomationTest.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes
{
    class ProcessB : AbstractProcessHandler
    {
        public override object Handle()
        {
            Console.WriteLine($"Done executing ProcessB.\n");

            return base.Handle();
        }
    }
}
