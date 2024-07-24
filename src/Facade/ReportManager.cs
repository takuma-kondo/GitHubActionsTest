namespace Facade
{
    public class ReportManager
    {
        public void NewReport(ReportType reportType)
        {
            var dataSource = DataSourceManager.Instance.GetDataSource();
            
            var reportService = ReportServiceFactory.Instance.GetReportService(reportType);
            reportService.GetReportData(dataSource);


            ReportRepository.Instance.AddReport();
        
        }
    }
}