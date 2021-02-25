using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;

namespace ProcessAutomationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IProcessAutomation processAutomation = new Chains.Chain1();
            processAutomation.RunChain();

            IProcessAutomation processAutomation2 = new Chains.Chain2();
            processAutomation2.RunChain();

            Console.ReadLine();
        }
    }
}
