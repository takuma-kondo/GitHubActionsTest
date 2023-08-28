using System;
using System.IO;

namespace BridgePattern
{
    public class OutputFille : OutputGreet
    {
        public OutputFille(Greet greet) : base(greet)
        {
        }

        public override void Output()
        {
            // デスクトップのフォルダパスを取得
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"BridgePattern.txt");
            File.AppendAllText(filePath,GetGreet());
        }
    }
}