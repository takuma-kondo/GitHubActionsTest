using System;

namespace Visitor
{
    public class OutputVisitor : IReportVisitor
    {
        public void Visit(TaskPackageReport taskPackageReport)
        {
            Console.WriteLine($"TaskPackageReport: {taskPackageReport.Name}");

            foreach (var task in taskPackageReport.TaskList)
            {
                task.Accept(this);
            }
        }

        public void Visit(TaskReport taskReport)
        {
            Console.WriteLine($"TaskReport: {taskReport.Name}");
        }
    }
}