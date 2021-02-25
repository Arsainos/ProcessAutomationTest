using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Interfaces
{
    public interface IProcessHandler
    {
        IProcessHandler SetNext(IProcessHandler handler);
        IProcessHandler SetError(IProcessHandler handler);
        IProcessHandler GetLastHandler();
        object Handle();
    }
}
