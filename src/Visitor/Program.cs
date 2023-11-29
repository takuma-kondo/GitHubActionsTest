using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // タスクレポートを複数作成
            var taskReport1 = new TaskReport { Name = "TaskReport1" };
            var taskReport2 = new TaskReport { Name = "TaskReport2" };
            var taskReport3 = new TaskReport { Name = "TaskReport3" };
            var taskReport4 = new TaskReport { Name = "TaskReport4" };

            // タスクパッケージレポートを複数作成
            var taskPackageReport1 = new TaskPackageReport { Name = "TaskPackageReport1" };  
            var taskPackageReport2 = new TaskPackageReport { Name = "TaskPackageReport2" };

            // ツリー構造の作成
            // タスクパッケージ1にタスクレポート1とタスクレポート2を追加
            taskPackageReport1.TaskList.Add(taskReport1);
            taskPackageReport1.TaskList.Add(taskReport2);

            // タスクパッケージ2にタスクレポート3とタスクレポート4とタスクパッケージ1を追加
            taskPackageReport2.TaskList.Add(taskReport3);
            taskPackageReport2.TaskList.Add(taskReport4);
            taskPackageReport2.TaskList.Add(taskPackageReport1);

            // Visitorを作成
            var outputVisitor = new OutputVisitor();

            // タスクパッケージレポートがVisitorをAccept
            taskPackageReport2.Accept(outputVisitor);

            Console.ReadKey();  
        }
    }
}
