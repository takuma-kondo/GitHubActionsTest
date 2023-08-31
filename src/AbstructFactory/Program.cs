using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 日本語の挨拶を取得する
            Console.WriteLine("日本語の挨拶");
            var japaneseFactory = JapaneseFactory.GetInstance();
            var greet = japaneseFactory.GetGreet();
            Console.WriteLine(greet.Morning);

            Console.ReadLine();
        }
    }
}
