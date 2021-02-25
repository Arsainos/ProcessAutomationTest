using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Abstracts
{
    abstract class AbstractProcessAutomation : IProcessAutomation
    {
        public object PayloadData;
        public abstract void RunChain();

    }
}
