namespace Composite;

public abstract class ReportEntory
{
    public string Name { get; set; }

    public string Parent { get; set; }

    public List<ReportEntory> ReportList { get; set; } = new List<ReportEntory>();

    public abstract void Remove();
}