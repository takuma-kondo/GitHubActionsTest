using System.IO;
using System.Text;

namespace FactoryMethod
{
    public abstract class Translator
    {
        public string InputWord { get; set; }

        protected void Input()
        {
            var sr = new StreamReader(@"C:\Users\10042000563\OneDrive - DENSO\デスクトップ\test.txt");

            InputWord = sr.ReadToEnd();

            sr.Close();
            sr.Dispose();
        }

        public abstract IWordChange CreateWordChange();

        protected void Output(IWordChange iWordChange)
        {
            var write = new StreamWriter(@"C:\Users\10042000563\OneDrive - DENSO\デスクトップ\test1.txt", false, iWordChange.Encode);
            write.WriteLine(iWordChange.WordChange(InputWord));
            write.Close();
            write.Dispose();
        }

        public void WordTranslator()
        {
            Input();
            var createWordChange = CreateWordChange();
            Output(createWordChange);
        }

    }
}