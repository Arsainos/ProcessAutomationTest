using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes
{
    class ProcessStart : AbstractProcessHandler, IProcessStart
    {
        public override object Handle()
        {
            Console.WriteLine($"Start Chain.\n");

            return base.Handle();
        }
    }
}
