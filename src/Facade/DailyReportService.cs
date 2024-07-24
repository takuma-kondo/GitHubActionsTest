using System;

namespace Facade
{
    public class DailyReportService : ReportService
    {
        public override void GetReportData(DataSource dataSource)
        {
            Console.WriteLine("レポートデータを取得");
        }
    }
}