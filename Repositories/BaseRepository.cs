using MySql.Data.MySqlClient;

namespace Zooverwaltung.Repositories
{
    public class BaseRepository
    {
        protected MySqlConnection connection;

        private const string connectionString =
    "server=localhost;database=zoodb;user=zoo_user;password=;Allow User Variables=True;";





        public BaseRepository()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
    }
}
