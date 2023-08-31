using System;

namespace BridgePattern
{
    public abstract class Output
    {
        /// <summary>
        /// 挨拶を表す抽象クラス
        /// </summary>
        protected Greet m_Greet;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="greet"></param>
        protected Output(Greet greet)
        {
            m_Greet = greet;
        }

        /// <summary>
        /// 挨拶を出力する
        /// </summary>
        public abstract void OutputGreet();

    }
}