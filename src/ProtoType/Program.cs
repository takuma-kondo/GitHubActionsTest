using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var datasource1 = "データソース1";
            var datasource2 = "データソース2";

            var prototype1 = new SummaryReport(datasource1);
            var prototype2 = new SummaryReport(datasource2);
            var clone1 = (SummaryReport)prototype1.Clone();
            var clone2 = (SummaryReport)prototype2.Clone();

            clone1.GetReport();
            clone2.GetReport();

            Console.ReadLine();
        }
    }
}
