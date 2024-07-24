using System;

namespace Facade
{
    public class ReportRepository
    {
        public static ReportRepository Instance { get; } = new ReportRepository();

        private ReportRepository()
        {
            
        }

        public void AddReport()
        {
            Console.WriteLine("レポートを追加しました。");
        }
    }
}