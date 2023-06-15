using System.Globalization;
using System.Text;

namespace FactoryMethod
{
    public interface IWordChange
    {
        Encoding Encode { get; }

        string WordChange(string input);
    }
}