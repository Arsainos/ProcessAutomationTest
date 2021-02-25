using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Interfaces
{
    public interface IProcessAutomation<T>
    {
        void RunChain(T payload);
    }
}
