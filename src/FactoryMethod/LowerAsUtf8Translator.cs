namespace FactoryMethod
{
    public class LowerAsUtf8Translator : Translator
    {
        public override IWordChange CreateWordChange()
        {
            return new LowerAsUtf8();
        }
    }
}