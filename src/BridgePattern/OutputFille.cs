using System;
using System.IO;

namespace BridgePattern
{
    public class OutputFille : Output
    {
        public OutputFille(Greet greet) : base(greet)
        {
        }

        public override void OutputGreet()
        {
            // デスクトップのフォルダパスを取得
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"BridgePattern.txt");
            File.AppendAllText(filePath, m_Greet.GetGreet());
        }
    }
}