namespace Composite;

public class ReportGroup:ReportEntory
{
    public List<ReportEntory> Children { get; set; } = new List<ReportEntory>();


    public  void AddChild(ReportEntory reportEntory)
    {
        Children.Add(reportEntory);
    }


    public override void Remove()
    {
        throw new NotImplementedException();
    }
}