using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using ProcessAutomationTest.ReferenceObjects;

namespace ProcessAutomationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IProcessAutomation processAutomation = new Chains.Chain1();
            processAutomation.RunChain(new AutomationChainShareObject() { ID = 1, Message = "10" });

            IProcessAutomation processAutomation2 = new Chains.Chain2();
            processAutomation2.RunChain(new AutomationChainShareObject() { ID = 1, Message = "20" });

            Console.ReadLine();
        }
    }
}
