using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // レポートタイプを指定してデータを取得
            IGetReportDataHandler handler = new MonthlyWorkHoursReportHandler();
            handler.Next = new DailyWorkHoursReportHandler();
            handler.Request(ReportType.Monthly);
            handler.Request(ReportType.Daily);
            handler.Request(ReportType.Weekly);

            Console.ReadKey();
        }
    }
}
