using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputGreet outputGreet = new OutputFille(new JapaneseGreet());
            outputGreet.Output();
        }
    }
}
