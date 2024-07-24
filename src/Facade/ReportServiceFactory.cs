namespace Facade
{
    public class ReportServiceFactory
    {
        public static ReportServiceFactory Instance { get; } = new ReportServiceFactory();

        private ReportServiceFactory()
        {
            
        }

        public ReportService GetReportService(ReportType reportType)
        {
            switch (reportType)
            {
                case ReportType.Daily:
                    return new DailyReportService();
                //case ReportType.Weekly:
                //    return new WeeklyReportService();
                //case ReportType.Monthly:
                //    return new MonthlyReportService();
                default:
                    return new DailyReportService();
            }
        }
    }
}