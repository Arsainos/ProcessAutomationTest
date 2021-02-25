using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Abstracts
{
    abstract class AbstractProcessAutomation : IProcessAutomation
    {
        private IProcessHandler _chain;

        public virtual void RunChain()
        {
            _chain.Handle();
        }

        public void SetChainMap(IProcessStart start, List<IProcessHandler> handlers, IProcessEnd end)
        {
            if(start != null)
            {
                this._chain = start;

                if (handlers.Count > 0)
                {
                    handlers.ForEach(handler =>
                    {
                        this._chain.GetLastHandler().SetNext(handler);
                    });
                }

                if (end != null)
                {
                    this._chain.GetLastHandler().SetNext(end);
                }
            }                               
        }
    }
}
