using System;
using System.IO;

namespace AdaptorPattern
{
    public class CreateFile : ICreate
    {
        public void Create()
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var folderPath = Path.Combine(desktopPath, "アダプターパターンファイル");

            File.Create(folderPath);
        }
    }
}