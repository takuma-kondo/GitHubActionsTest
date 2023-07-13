using System;

namespace ProtoType
{
    public class SummaryReport : ICloneable
    {
        string DataSource { get; set; }

        public SummaryReport(string datasource)
        {
            DataSource = datasource;
            GetReport();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void GetReport()
        {
            Console.WriteLine("{0}から集計レポートを取得しました", DataSource);
        }
    }
}