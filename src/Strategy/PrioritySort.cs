namespace Strategy;

public class PrioritySort:IssueSort
{
    public override void Sort(List<Issue> issues)
    {
        issues.Sort((x, y) =>
            {
                var priorityCompare = x.Priority.CompareTo(y.Priority);
                if (priorityCompare == 0)
                {
                    return String.Compare(x.Id, y.Id, StringComparison.Ordinal);
                }

                return priorityCompare;
            }
        );
    }
    
}