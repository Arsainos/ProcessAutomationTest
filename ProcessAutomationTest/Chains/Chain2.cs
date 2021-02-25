using System;
using System.Collections.Generic;
using System.Text;
using ProcessAutomationTest.Concrete;
using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.Processes.Chain2;

namespace ProcessAutomationTest.Chains
{
    class Chain2 : ProcessAutomation
    {
        List<IProcessHandler> processHandlers => new List<IProcessHandler>()
        {
            new ProcessStart(),
            new ProcessA(),
            new ProcessB(),
            new ProcessEnd()
        };

        public Chain2(object payloadData)
        {
            PayloadData = payloadData;

            SetChainMap(processHandlers);
        }
    }
    
}
