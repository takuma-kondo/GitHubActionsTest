namespace Strategy;

public abstract class IssueSort
{
    #region 公開メソッド

    public virtual void Sort(List<Issue> issues)
    {
        issues.Sort((x, y) => x.Id.CompareTo(y.Id));
    }

    #endregion
}