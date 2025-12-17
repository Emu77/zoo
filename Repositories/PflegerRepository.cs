using MySql.Data.MySqlClient;
using Zooverwaltung.Models;

namespace Zooverwaltung.Repositories
{
    public class PflegerRepository : BaseRepository
    {
        public List<Pfleger> GetAll()
        {
            var list = new List<Pfleger>();
            using var cmd = new MySqlCommand("SELECT PflegerID, Name FROM Pfleger", connection);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Pfleger
                {
                    PflegerID = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }
            return list;
        }
    }
}
