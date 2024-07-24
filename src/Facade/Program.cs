﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reportManager = new ReportManager();
            reportManager.NewReport(ReportType.Daily);

            Console.ReadKey();
        }
    }
}
