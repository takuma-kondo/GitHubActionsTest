using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var createDirectory = new CreateDirectory();
            var createFile = new CreateFile();

            Create(createDirectory);
            Create(createFile);
        }

        static void Create(ICreate obj)
        {
            obj.Create();
        }
    }
}
