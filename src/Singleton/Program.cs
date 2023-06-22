
namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase db = DataBase.GetInstance();
            db.Connect();
            db.GetData();
            db.Disconnect();
        }
    }
}
