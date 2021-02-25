using ProcessAutomationTest.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes
{
    class ProcessC : AbstractProcessHandler
    {
        public override object Handle()
        {
            Console.WriteLine($"Done executing ProcessC.\n");

            return base.Handle();
        }
    }
}
