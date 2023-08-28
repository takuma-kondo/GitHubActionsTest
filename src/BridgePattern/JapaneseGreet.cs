namespace BridgePattern
{
    public class JapaneseGreet : Greet
    {
        public override string GetMorning()
        {
            return "おはよう";
        }

        public override string GetAfternoon()
        {
            return "こんにちは";
        }

        public override string GetNight()
        {
            return "おやすみ";
        }
    }
}