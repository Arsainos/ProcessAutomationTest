using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Abstracts
{
    abstract class AbstractProcessAutomation : IProcessAutomation
    {
        public object PayloadData;
        public List<IProcessHandler> Chain { get; protected set; }
        public abstract void RunChain();
        public abstract void SetChainMap(List<IProcessHandler> handlers);
    }
}
