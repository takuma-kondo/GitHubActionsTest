namespace Composite;

public abstract class ReportEntry
{
    public string Name { get; set; }

    public ReportGroup Parent { get; set; }

    public static readonly IDictionary<ReportEntry, IList<ReportEntry>> FlatReportEntries = new Dictionary<ReportEntry, IList<ReportEntry>>();

    public virtual void RemoveRecursive()
    {
        if (Parent != null)
        {
            // 親の子供から自身を削除
            Parent.Children.Remove(this);

            // 親をnullにする
            this.Parent = null;
        }
    }

    public void RemoveFlatCollection()
    {
        /* 親のReportGroupをキーに持ちその子をValue としたDictionary をよういする
 　    追加する際は、親を探してなければ新規に追加
       削除する際は、親を探してValueから削除、KeyからVauleをstackに積み、popする際にその値をkeyとしたvalueを削除する*/

        var removeTargetStack = new Stack<ReportEntry>();

        // 自身を削除対象に追加
        removeTargetStack.Push(this);

        while (removeTargetStack.Count > 0)
        {
            var removeTarget = removeTargetStack.Pop();

            if (removeTarget.Parent != null)
            {
                // 親の子供から自身を削除
                removeTarget.Parent.Children.Remove(this);

                if (removeTarget.Parent.Children.Count == 0)
                {
                    FlatReportEntries.Remove(removeTarget.Parent);
                }

                // 親をnullにする
                removeTarget.Parent = null;
            }

            if (!FlatReportEntries.ContainsKey(removeTarget)) continue;

            // 自身をキーに持つValueを削除
            foreach (var childEntry in FlatReportEntries[removeTarget])
            {
                removeTargetStack.Push(childEntry);
            }
        }
    }
}