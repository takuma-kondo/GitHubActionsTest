using System;

namespace ChainOfResponsibility
{
    public class DailyWorkHoursReportHandler : IGetReportDataHandler
    {
        public IGetReportDataHandler Next { get; set; }

        public void Request(ReportType reportType)
        {
            if (reportType == ReportType.Daily)
            {
                Console.WriteLine("日報のデータを取得します。");
            }
            else if (Next != null)
            {
                Next.Request(reportType);
            }
            else
            {
                Console.WriteLine("対応するレポートタイプではありません");
            }
        }
    }
}