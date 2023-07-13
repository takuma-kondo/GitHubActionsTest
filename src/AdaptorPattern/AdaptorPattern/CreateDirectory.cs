using System;
using System.IO;

namespace AdaptorPattern
{
    /// <summary>
    /// Adapterのクラス
    /// </summary>
    public class CreateDirectory : ICreate
    {
        public void Create()
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var directoryPath = Path.Combine(desktopPath, "アダプターパターンフォルダ");

            // フォルダを作成する
            Directory.CreateDirectory(directoryPath);
        }
    }
}