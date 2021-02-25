using System;
using System.Collections.Generic;
using System.Text;
using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.Processes.Chain2;
using ProcessAutomationTest.ReferenceObjects;

namespace ProcessAutomationTest.Chains
{
    class Chain2 : AbstractProcessAutomation<AutomationChainShareObject>
    {
        public Chain2()
        {
            Chain
                .AddRange(new List<IProcessHandler<AutomationChainShareObject>>()
                {
                    new ProcessStart(),
                    new ProcessA(),
                    new ProcessB(),
                    new ProcessEnd()
                });
        }
    }
    
}
