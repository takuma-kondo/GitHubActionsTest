using System;

namespace ChainOfResponsibility
{
    public class MonthlyWorkHoursReportHandler: IGetReportDataHandler
    {
        public IGetReportDataHandler Next { get; set; }

        public void Request(ReportType reportType)
        {
            if (reportType == ReportType.Monthly)
            {
                Console.WriteLine("月報のデータを取得します。");
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