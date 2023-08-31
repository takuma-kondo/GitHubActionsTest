using System;
using System.Collections.Generic;
using System.Globalization;

namespace BridgePattern
{
    public class OutputConsole : Output
    {

        public OutputConsole(Greet greet) : base(greet)
        {
        }

        public override void OutputGreet()
        {
            Console.WriteLine(m_Greet.GetGreet());
        }
    }
}