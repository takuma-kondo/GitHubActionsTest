namespace Visitor
{
    public class TaskReport : IWBSNodeAcceptor
    {
        public string Name { get; set; }

        public void Accept(IReportVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}