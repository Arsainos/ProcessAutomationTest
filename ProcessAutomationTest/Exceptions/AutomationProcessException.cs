using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Exceptions
{
    public class AutomationProcessException : Exception
    {       
        public AutomationProcessException() : base()
        {
            //Log message
            Console.WriteLine("Exception occured");
        }
    }
}
