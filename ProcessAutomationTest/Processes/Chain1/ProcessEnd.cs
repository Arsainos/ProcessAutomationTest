using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes
{
    class ProcessEnd : AbstractProcessHandler, IProcessEnd
    {
        public override object Handle()
        {
            Console.WriteLine($"End Chain.\n");

            return base.Handle();
        }
    }
}
