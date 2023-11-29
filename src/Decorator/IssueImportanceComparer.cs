using System;

namespace Decorator
{
    /// <summary>
    /// 重大度で比較するデコレーター
    /// </summary>
    public class IssueImportanceComparer:IIssueComparer
    {
        /// <summary>
        /// 比較するデコレーター
        /// </summary>
        private readonly IIssueComparer m_IssueComparer;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="issueComparer"></param>
        public IssueImportanceComparer(IIssueComparer issueComparer)
        {
            m_IssueComparer = issueComparer;
        }

        /// <summary>
        /// 重大度で比較する
        /// 重大度が同じ場合は、別の要素で比較する
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Compare(Issue x, Issue y)
        {
            // xまたはyがnullの場合は、例外を投げる
            if (x == null || y == null) throw new ArgumentNullException();

            // x,yの重大度を比較して、xの重大度が大きければ1、yの重大度が大きければ-1、同じなら別の要素で比較する
            var importanceCompare = x.Importance.CompareTo(y.Importance);

            // 重大度が同じ場合は、別の要素で比較する
            if (importanceCompare == 0)
            {
                return m_IssueComparer.Compare(x, y);
            }

            return importanceCompare;
        }
    }
}