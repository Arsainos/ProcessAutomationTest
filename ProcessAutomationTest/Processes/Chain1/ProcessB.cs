﻿using ProcessAutomationTest.Abstracts;
using ProcessAutomationTest.ReferenceObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain1
{
    class ProcessB : AbstractProcessHandler<AutomationChainShareObject>
    {
        public override void Execute(AutomationChainShareObject payload)
        {
            payload.Message += "10";

            Console.WriteLine(payload.Message);

            Console.WriteLine($"Done executing ProcessB.\n");
        }
    }
}
