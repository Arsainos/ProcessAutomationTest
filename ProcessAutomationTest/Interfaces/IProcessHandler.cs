using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Interfaces
{
    public interface IProcessHandler<T>
    {
        void Execute(T payload);
    }
}
