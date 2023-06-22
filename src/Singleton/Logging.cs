namespace Singleton;

/// <summary>
/// ログ出力を行うクラス
/// </summary>
public class Logging
{
    /// <summary>
    /// インスタンス
    /// </summary>
    private static Logging s_Instance = new Logging();

    /// <summary>
    /// コンストラクタ
    /// </summary>
    private Logging()
    {
    }

    /// <summary>
    /// インスタンスを返す
    /// </summary>
    /// <returns></returns>
    public static Logging GetInstance()
    {
        return s_Instance;
    }

    /// <summary>
    /// ログを出力する
    /// </summary>
    /// <param name="message"></param>
    public void PrintLog(string message)
    {
        Console.WriteLine(message);
        Console.ReadLine();
    }
}