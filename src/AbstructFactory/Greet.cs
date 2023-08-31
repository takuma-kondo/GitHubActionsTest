using System;

namespace AbstractFactory
{
    /// <summary>
    /// 挨拶のクラス
    /// Prototypeパターンも実装するためICloneableを継承する
    /// </summary>
    public class Greet : ICloneable
    {
        /// <summary>
        /// 朝の挨拶
        /// </summary>
        public string Morning { get; set; }

        /// <summary>
        /// 昼の挨拶
        /// </summary>
        public string Noon { get; set; }

        /// <summary>
        /// 夜の挨拶
        /// </summary>
        public string Night { get; set; }

        /// <summary>
        /// コンストラクタ
        /// 挨拶の文字列を設定する
        /// </summary>
        /// <param name="morning"></param>
        /// <param name="noon"></param>
        /// <param name="night"></param>
        public Greet(string morning, string noon, string night)
        {
            Morning = morning;
            Noon = noon;
            Night = night;
        }

        /// <summary>
        /// オブジェクトのクローンを作成する
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Greet(Morning, Noon,Night);

            //return this.MemberwiseClone();
        }
    }
}