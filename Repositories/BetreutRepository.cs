using MySql.Data.MySqlClient;
using Zooverwaltung.Models;

namespace Zooverwaltung.Repositories
{
    public class BetreutRepository : BaseRepository
    {
        public List<Betreut> GetByGehege(int gehegeId)
        {
            var list = new List<Betreut>();

            using var cmd = new MySqlCommand(
                "SELECT GehegeID, PflegerID, Hauptpfleger FROM betreut WHERE GehegeID=@gid",
                connection);
            cmd.Parameters.AddWithValue("@gid", gehegeId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Betreut
                {
                    GehegeID = reader.GetInt32(0),
                    PflegerID = reader.GetInt32(1),
                    Hauptpfleger = reader.GetBoolean(2)
                });
            }
            return list;
        }

        public void Insert(Betreut b)
        {
            using var cmd = new MySqlCommand(
                "INSERT INTO betreut (GehegeID, PflegerID, Hauptpfleger) VALUES (@g, @p, @h)",
                connection);
            cmd.Parameters.AddWithValue("@g", b.GehegeID);
            cmd.Parameters.AddWithValue("@p", b.PflegerID);
            cmd.Parameters.AddWithValue("@h", b.Hauptpfleger);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int gehegeId, int pflegerId)
        {
            using var cmd = new MySqlCommand(
                "DELETE FROM betreut WHERE GehegeID=@g AND PflegerID=@p",
                connection);
            cmd.Parameters.AddWithValue("@g", gehegeId);
            cmd.Parameters.AddWithValue("@p", pflegerId);
            cmd.ExecuteNonQuery();
        }

        public void ClearHauptpfleger(int gehegeId)
        {
            using var cmd = new MySqlCommand(
                "UPDATE betreut SET Hauptpfleger=0 WHERE GehegeID=@g",
                connection);
            cmd.Parameters.AddWithValue("@g", gehegeId);
            cmd.ExecuteNonQuery();
        }
    }
}
