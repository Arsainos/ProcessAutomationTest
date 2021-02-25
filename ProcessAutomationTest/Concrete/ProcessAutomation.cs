using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ProcessAutomationTest.Abstracts;

namespace ProcessAutomationTest.Concrete
{
    class ProcessAutomation : AbstractProcessAutomation
    {
        private List<IProcessHandler> _chain;

        public override void RunChain()
        {
            foreach (var process in this._chain)
            {
                process.Execute(ref PayloadData);
            }
        }

        public void SetChainMap(List<IProcessHandler> handlers)
        {
            _chain = handlers;
        }
    }
}
