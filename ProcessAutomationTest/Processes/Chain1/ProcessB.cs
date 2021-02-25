﻿using ProcessAutomationTest.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Processes.Chain1
{
    class ProcessB : AbstractProcessHandler
    {
        public override void Execute()
        {
            Console.WriteLine($"Done executing ProcessB.\n");
        }
    }
}
