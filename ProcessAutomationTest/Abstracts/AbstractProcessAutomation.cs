using ProcessAutomationTest.Interfaces;
using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Abstracts
{
    abstract class AbstractProcessAutomation<T> : IProcessAutomation<T>
    {
        protected List<IProcessHandler<T>> Chain { get; private set; }
        public void RunChain(T payload)
        {
            foreach (var process in Chain)
            {
                process.Execute(payload);
            }
        }

        public AbstractProcessAutomation()
        {
            this.Chain = new List<IProcessHandler<T>>();
        }
    }
}
