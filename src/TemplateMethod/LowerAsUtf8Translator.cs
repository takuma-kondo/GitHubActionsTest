using System.IO;
using System.Text;

namespace TemplateMethod
{
    public class LowerAsUtf8Translator:Tranlator
    {
        protected override void WordChange()
        {
            InputWord = InputWord.ToLower();
        }

        protected override void Output()
        {
           var write = new StreamWriter(@"C:\Users\10042000563\OneDrive - DENSO\デスクトップ\test1.txt", false,Encoding.UTF32);
           write.WriteLine(InputWord);
            write.Close();
            write.Dispose();
        }
    }
}