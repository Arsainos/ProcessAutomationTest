using System;
using System.Collections.Generic;
using System.Text;
using ProcessAutomationTest.Concrete;
using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.Processes.Chain1;

namespace ProcessAutomationTest.Chains
{
    class Chain1 : ProcessAutomation
    {
        List<IProcessHandler> processHandlers => new List<IProcessHandler>() 
        { 
            new ProcessStart(),  
            new ProcessA(),
            new ProcessB(),
            new ProcessC(),
            new ProcessEnd()
        };

        public Chain1(object payloadData)
        {
            PayloadData = payloadData;

            SetChainMap(processHandlers);
        }
    }
}
