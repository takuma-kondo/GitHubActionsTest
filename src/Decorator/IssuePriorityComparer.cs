using System;

namespace Decorator
{
    /// <summary>
    /// 優先度で比較するデコレーター
    /// </summary>
    public class IssuePriorityComparer:IIssueComparer
    {
        /// <summary>
        /// 比較するデコレーター
        /// </summary>
        private readonly IIssueComparer m_IssueComparer;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="issueComparer"></param>
        /// <exception cref="System.NotImplementedException"></exception>
        public IssuePriorityComparer(IIssueComparer issueComparer)
        {
            m_IssueComparer = issueComparer;
        }

        /// <summary>
        /// 優先度で比較する
        /// 同じ優先度の場合は、別の要素で比較する
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int Compare(Issue x, Issue y)
        {
            // xまたはyがnullの場合は、例外を投げる
            if (x == null || y == null) throw new ArgumentNullException();

            // x,yの優先度を比較して、xの優先度が大きければ1、yの優先度が大きければ-1、同じなら別の要素で比較する
            var priorityCompare = x.Priority.CompareTo(y.Priority);

            // 優先度が同じ場合は、別の要素で比較する
            if(priorityCompare == 0)
            {
                return m_IssueComparer.Compare(x, y);
            }

            return priorityCompare;
        }
    }
}