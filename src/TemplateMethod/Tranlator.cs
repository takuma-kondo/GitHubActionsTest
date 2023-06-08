using System.IO;

namespace TemplateMethod
{
    public abstract class Tranlator
    {
        public string InputWord { get; set; }

        protected void Input()
        {
            var sr = new StreamReader(@"C:\Users\10042000563\OneDrive - DENSO\デスクトップ\test.txt");

            InputWord = sr.ReadToEnd();

            sr.Close();
            sr.Dispose();
        }

        protected abstract void WordChange();

        protected abstract void Output();

        public void WordTranlator()
        {
            Input();
            WordChange();
            Output();
        }

    }
}
