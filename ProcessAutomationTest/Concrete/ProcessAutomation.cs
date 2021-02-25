using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ProcessAutomationTest.Abstracts;

namespace ProcessAutomationTest.Concrete
{
    class ProcessAutomation : AbstractProcessAutomation
    {        
        public override void RunChain()
        {
            foreach (var process in Chain)
            {
                process.Execute(ref PayloadData);
            }
        }

        public override void SetChainMap(List<IProcessHandler> handlers)
        {
            Chain = handlers;
        }
    }
}
