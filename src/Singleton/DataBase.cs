namespace Singleton;

/// <summary>
/// データベースの処理を行うクラス
/// </summary>
public class DataBase
{
    #region フィールド

    /// <summary>
    /// インスタンス
    /// </summary>
    private static DataBase s_Instance = new DataBase();

    #endregion

　　/// <summary>
    /// インスタンスを返す
    /// </summary>
    /// <returns></returns>
    public static DataBase GetInstance()
    {
        return s_Instance;
    }

    #region 構築

    /// <summary>
    /// コンストラクタ
    /// </summary>
    private DataBase()
    {
    }

    #endregion

    #region メソッド

    /// <summary>
    /// データベースに接続
    /// </summary>
    public void Connect()
    {
        Console.WriteLine("データベースに接続しました");
        Logging.GetInstance().PrintLog(nameof(Connect));
    }

    /// <summary>
    /// データベースからデータを取得
    /// </summary>
    public void GetData()
    {
        Console.WriteLine("データを取得しました");
        Logging.GetInstance().PrintLog(nameof(GetData));
    }

    /// <summary>
    /// データベースに接続解除
    /// </summary>
    public void Disconnect()
    {
        Console.WriteLine("データベースから切断しました");
        Logging.GetInstance().PrintLog(nameof(Disconnect));
    }

    #endregion
}

