
using MySql.Data.MySqlClient;

namespace Zooverwaltung
{
    public static class Db
    {
        // Bitte anpassen an deine MySQL-Installation
        private static string connString =
            "server=localhost;database=zoodb;user=zoo_user;password=;"
;

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}
