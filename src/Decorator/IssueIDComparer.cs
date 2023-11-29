using System;

namespace Decorator
{
    public class IssueIDComparer: IIssueComparer
    {
        public int Compare(Issue x, Issue y)
        {
            // xまたはyがnullの場合は、例外を投げる
            if (x == null || y == null) throw new ArgumentNullException();

            // x,yのIDを比較して、xのIDが大きければ1、yのIDが大きければ-1、同じなら0を返す
            return Int32.Parse(x.Id).CompareTo(Int32.Parse(y.Id));
        }
    }
}