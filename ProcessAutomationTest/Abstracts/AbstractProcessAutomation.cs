using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Abstracts
{
    abstract class AbstractProcessAutomation : IProcessAutomation
    {
        public List<IProcessHandler> Chain { get; protected set; }
        public void RunChain(AutomationChainShareObject payload)
        {
            foreach (var process in Chain)
            {
                process.Execute(payload);
            }
        }

        public AbstractProcessAutomation()
        {
            this.Chain = new List<IProcessHandler>();
        }
    }
}
