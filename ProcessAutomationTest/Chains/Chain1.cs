using System;
using System.Collections.Generic;
using System.Text;
using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.Processes.Chain1;
using ProcessAutomationTest.ReferenceObjects;

namespace ProcessAutomationTest.Chains
{
    class Chain1 : AbstractProcessAutomation
    {
        public Chain1()
        {
            Chain
                .AddRange(new List<IProcessHandler>()
                {
                    new ProcessStart(),
                    new ProcessA(),
                    new ProcessB(),
                    new ProcessC(),
                    new ProcessEnd()
                });
        }
    }
}
