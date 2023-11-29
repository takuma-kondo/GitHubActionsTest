namespace Visitor
{
    public interface IReportVisitor
    {
        void Visit(TaskPackageReport taskPackageReport);

        void Visit(TaskReport taskReport);
    }
}