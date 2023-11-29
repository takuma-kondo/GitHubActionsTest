using System.Collections.Generic;

namespace Visitor
{
    public class TaskPackageReport : IWBSNodeAcceptor
    {
        public string Name { get; set; }

        public List<IWBSNodeAcceptor> TaskList { get;} = new List<IWBSNodeAcceptor>();

        public void Accept(IReportVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}