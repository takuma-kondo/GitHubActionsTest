using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 三角形を生成
            var triangle = new Triangle() { SideA = 8, SideB = 8, SideC =9 };

            // 三角形のビルダーを生成
            var builder = new TriangleAreaBuilder(triangle);

            var director = new Director(builder);
            director.Construct();

            Console.ReadLine();
        }
    }
}
