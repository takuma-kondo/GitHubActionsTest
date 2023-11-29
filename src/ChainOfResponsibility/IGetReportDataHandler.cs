namespace ChainOfResponsibility
{
    public interface IGetReportDataHandler
    {
        IGetReportDataHandler Next { get; set; }

        void Request(ReportType reportType);
    }
}