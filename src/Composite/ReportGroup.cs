namespace Composite;

public class ReportGroup:ReportEntry
{
    public IList<ReportEntry> Children => FlatReportEntries[this];


    public  void AddChild(ReportEntry reportEntry)
    {
        // 親を設定
        reportEntry.Parent = this;

        // フラットなコレクションに追加
        if (FlatReportEntries.ContainsKey(this))
        {
            FlatReportEntries[this].Add(reportEntry);
        }
        else
        {
            FlatReportEntries.Add(this, new List<ReportEntry> { reportEntry });
        }
    }

    // 再帰で親が持っているChildrenから削除する
    public override void RemoveRecursive()
    {
        base.RemoveRecursive();

        // 自身の子供を再帰的に削除
        var copy = Children.ToArray();
        foreach (var child in copy)
        {
            child.RemoveRecursive();
        }
    }
}
