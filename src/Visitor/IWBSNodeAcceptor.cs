namespace Visitor
{
    public interface IWBSNodeAcceptor
    {
        void Accept(IReportVisitor visitor);
    }
}