﻿namespace Strategy;

public class IssueImportanceSort: IssueSort
{
    #region 公開メソッド

    public override void Sort(List<Issue> issues)
    {
        issues.Sort((x, y) =>
            {
                var importanceCompare = x.Importance.CompareTo(y.Importance);
                if (importanceCompare == 0)
                {
                    return String.Compare(x.Id, y.Id, StringComparison.Ordinal);
                }

                return importanceCompare;
            }
        );
    }

    #endregion
}