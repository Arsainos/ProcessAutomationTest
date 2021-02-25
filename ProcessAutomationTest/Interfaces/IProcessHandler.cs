using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Interfaces
{
    public interface IProcessHandler
    {
        void Execute(ref object payload);
    }
}
