using System.Diagnostics;
using Debug = System.Diagnostics.Debug;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 階層構造を作る
            // ルート
            var root = new ReportGroup { Name = "root"};

            // ルート直下のレポートエントリー
            var group1_1 = new ReportGroup { Name = "group1-1"};
            var group1_2 = new ReportGroup { Name = "group1-2"};
            var report1_1 = new Report     { Name = "report1-1"};
            // ルート直下に追加
            root.AddChild(group1_1);
            root.AddChild(group1_2);
            root.AddChild(report1_1);

            // グループ1の直下のレポートエントリー
            var group2_1 = new ReportGroup { Name = "group2_1"};
            var report2_1 = new Report { Name = "report2-1"};
            var report2_2 = new Report { Name = "report2-2"};
            // グループ1の直下に追加
            group1_1.AddChild(group2_1);
            group1_1.AddChild(report2_1);
            group1_1.AddChild(report2_2);

            // グループ2の直下のレポートエントリー
            var report3_1 = new Report { Name = "report3-1"};
            var report3_2 = new Report { Name = "report3-2"};
            // グループ2の直下に追加
            group2_1.AddChild(report3_1);
            group2_1.AddChild(report3_2);

            var sw = Stopwatch.StartNew();

            // 以降削除の処理を実装
            // ルート直下のレポートエントリーの削除
            report1_1.RemoveRecursive();
            group1_1.RemoveRecursive();

            //report1_1.RemoveFlatCollection();
            //group1_1.RemoveFlatCollection();

            //計測の停止
            sw.Stop();

            //計測結果の出力
            Console.WriteLine("計測時間：{0}", sw.Elapsed);

            Console.ReadLine();

            // Debug.Assert(root.Children.Count == 1);
            //Debug.Assert(root.Children[0].Name == "group1-2");


        }
    }
}