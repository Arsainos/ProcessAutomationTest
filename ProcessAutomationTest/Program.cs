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
            IProcessAutomation processAutomation = new Chains.Chain1(new AutomationChainShareObject() { ID = 1, Message = "10" });
            processAutomation.RunChain();

            IProcessAutomation processAutomation2 = new Chains.Chain2(new AutomationChainShareObject() { ID = 1, Message = "20" });
            processAutomation2.RunChain();

            Console.ReadLine();
        }
    }
}
