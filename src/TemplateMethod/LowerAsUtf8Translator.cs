using System.IO;
using System.Text;

namespace TemplateMethod
{
    public class LowerAsUtf8Translator:Tranlator
    {
        protected override void WordChange()
        {
            InputWord = InputWord.ToLower();
            Encode = Encoding.UTF8;
        }
    }
}