namespace AbstructFactory
{
    public class JapaneseFactory : IGreetFactory
    {
        private Greet m_StandardGreet;

        private static JapaneseFactory s_Instance = new JapaneseFactory();


        /// <summary>
        /// コンストラクタ
        /// クラスがsealedの場合はprivateでもよいが、sealedではない場合はprotectedにする
        /// privateにすると継承先でインスタンスが作成できなくなる
        /// </summary>
        private JapaneseFactory()
        {
            m_StandardGreet = new Greet("おはようございます", "こんにちは", "おやすみ");
        }


        public static JapaneseFactory GetInstance()
        {
            return s_Instance;
        }

        public Greet GetGreet()
        {
           return (Greet)m_StandardGreet.Clone();
        }
    }
}