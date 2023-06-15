using System.IO;
using System.Text;

namespace TemplateMethod
{
    public abstract class Tranlator
    {
        public string InputWord { get; set; }

        public Encoding Encode { get; set; }

        protected void Input()
        {
            var sr = new StreamReader(@"C:\Users\10042000563\OneDrive - DENSO\デスクトップ\test.txt");

            InputWord = sr.ReadToEnd();

            sr.Close();
            sr.Dispose();
        }

        protected abstract void WordChange();

        protected void Output()
        {
            var write = new StreamWriter(@"C:\Users\10042000563\OneDrive - DENSO\デスクトップ\test1.txt", false, Encode);
            write.WriteLine(InputWord);
            write.Close();
            write.Dispose();
        }

        public void WordTranlator()
        {
            Input();
            WordChange();
            Output();
        }

    }
}
