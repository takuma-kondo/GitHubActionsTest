using System;
using System.Collections.Generic;
using System.Globalization;

namespace BridgePattern
{
    public class OutputConsole : OutputGreet
    {

        public OutputConsole(Greet greet) : base(greet)
        {
        }

        public override void Output()
        {
            Console.WriteLine(GetGreet());
        }

    }
}