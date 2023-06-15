using System.Text;

namespace FactoryMethod
{
    public class LowerAsUtf8 : IWordChange
    {
        public Encoding Encode  => Encoding.UTF8 ; 

        public string WordChange(string input)
        {
            return input.ToLower();
        }
    }
}