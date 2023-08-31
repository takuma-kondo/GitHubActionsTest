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
            // ファイルに日本語で挨拶を出力する
            Output japaneseFile = new OutputFille(new JapaneseGreet());
            japaneseFile.OutputGreet();

            // コンソールに英語で挨拶を出力する
            Output englishConsole = new OutputConsole(new JapaneseGreet());
            englishConsole.OutputGreet();

            Console.ReadLine();
        }
    }
}
