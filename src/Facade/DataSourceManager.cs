namespace Facade
{
    public class DataSourceManager
    {

        public static DataSourceManager Instance { get; } = new DataSourceManager();

        private DataSourceManager()
        {

        }

        public DataSource GetDataSource()
        {
            return new DataSource() {Name = "データソース1"};
        }
    }
}
