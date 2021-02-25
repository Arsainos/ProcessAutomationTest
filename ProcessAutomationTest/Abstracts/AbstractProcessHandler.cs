using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Abstracts
{
    abstract class AbstractProcessHandler : IProcessHandler
    {
        public abstract void Execute(AutomationChainShareObject payload);
    }
}
