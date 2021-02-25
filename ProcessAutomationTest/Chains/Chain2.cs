using System;
using System.Collections.Generic;
using System.Text;
using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.Processes.Chain2;
using ProcessAutomationTest.ReferenceObjects;

namespace ProcessAutomationTest.Chains
{
    class Chain2 : AbstractProcessAutomation
    {
        public Chain2()
        {
            Chain
                .AddRange(new List<IProcessHandler>()
                {
                    new ProcessStart(),
                    new ProcessA(),
                    new ProcessB(),
                    new ProcessEnd()
                });
        }
    }
    
}
