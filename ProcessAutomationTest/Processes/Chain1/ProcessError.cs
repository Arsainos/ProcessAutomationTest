using ProcessAutomationTest.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes
{
    class ProcessError : AbstractProcessHandler
    {
        public override object Handle()
        {
            return $"Error Occured. Rollback.\n";
        }
    }
}
