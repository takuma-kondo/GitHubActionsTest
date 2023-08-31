namespace AbstractFactory
{
    public class JapaneseFactory : IGreetFactory
    {
        /// <summary>
        /// 標準語の挨拶
        /// </summary>
        private Greet m_StandardGreet;

        /// <summary>
        /// 沖縄弁の挨拶
        /// </summary>
        private Greet m_OkinawaGreet;

        /// <summary>
        /// japaneseFactoryのインスタンス
        /// シングルトンパターンを実装するためstaticにする
        /// </summary>
        private static JapaneseFactory s_Instance = new JapaneseFactory();


        /// <summary>
        /// コンストラクタ
        /// クラスがsealedの場合はprivateでもよいが、sealedではない場合はprotectedにする
        /// privateにすると継承先でインスタンスが作成できなくなる
        /// </summary>
        protected JapaneseFactory()
        {
            m_StandardGreet = new Greet("おはよう", "こんにちは", "おやすみ");
            m_OkinawaGreet = new Greet("うきみそーちー", "はいさい", "にんじみそーれー");
        }

        /// <summary>
        /// インタンスを取得する
        /// シングルトンパターンの実装
        /// </summary>
        /// <returns></returns>
        public static JapaneseFactory GetInstance()
        {
            return s_Instance;
        }

        /// <summary>
        /// 挨拶を取得する
        /// </summary>
        /// <returns></returns>
        public Greet GetGreet()
        {
           return (Greet)m_StandardGreet.Clone();
        }
    }
}