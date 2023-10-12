namespace Strategy;

public class Issue
{
    #region プロパティ

    /// <summary>
    /// 指摘のID
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// 指摘の優先度
    /// </summary>
    public Priority Priority { get; set; }

    /// <summary>
    /// 指摘の重大度
    /// </summary>
    public Importance Importance { get; set; }

    /// <summary>
    /// 指摘のアウトラインノード名
    /// </summary>
    public string OutlineNodeName { get; set; }

    #endregion
}