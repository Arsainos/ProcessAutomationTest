﻿using ProcessAutomationTest.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain2
{
    class ProcessA : AbstractProcessHandler
    {
        public override void Execute(ref object payload)
        {
            Console.WriteLine($"Done executing ProcessA.\n");
        }
    }
}
