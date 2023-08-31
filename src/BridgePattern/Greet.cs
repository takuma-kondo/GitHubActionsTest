namespace BridgePattern
{
    /// <summary>
    /// 挨拶を表す抽象クラス
    /// </summary>
    public abstract class Greet
    {
        /// <summary>
        /// 挨拶を取得する
        /// </summary>
        /// <returns></returns>
        public abstract string GetGreet();

        /// <summary>
        /// 現在の時間帯を取得する
        /// 各国の現在時刻を取得して、それに応じて挨拶を変える
        /// </summary>
        /// <returns></returns>
        protected abstract TimeSlot GetNowTimeSlot();
    }
}