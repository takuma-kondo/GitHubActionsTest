namespace BridgePattern
{
    public class EnglishGreet : Greet
    {
        public override string GetMorning()
        {
            return "Good Morning";
        }

        public override string GetAfternoon()
        {
            return "Hello";
        }

        public override string GetNight()
        {
            return "Good Night";
        }
    }
}