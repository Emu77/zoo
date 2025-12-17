
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Zooverwaltung.Models;

namespace Zooverwaltung.Repositories
{
    public class GehegeRepository : BaseRepository
    {
        public List<Gehege> GetAll()
        {
            var list = new List<Gehege>();
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "SELECT gID, GBezeichnung, KontinentID FROM Gehege";
            using var cmd = new MySqlCommand(sql, con);
            using var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                list.Add(new Gehege
                {
                    gID = rd.GetInt32("gID"),
                    GBezeichnung = rd.GetString("GBezeichnung"),
                    KontinentID = rd.GetInt32("KontinentID")
                });
            }
            return list;
        }

        public void Insert(Gehege g)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "INSERT INTO Gehege (GBezeichnung, KontinentID) VALUES (@bez, @kid)";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bez", g.GBezeichnung);
            cmd.Parameters.AddWithValue("@kid", g.KontinentID);
            cmd.ExecuteNonQuery();
        }

        public void Update(Gehege g)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "UPDATE Gehege SET GBezeichnung=@bez, KontinentID=@kid WHERE gID=@id";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@bez", g.GBezeichnung);
            cmd.Parameters.AddWithValue("@kid", g.KontinentID);
            cmd.Parameters.AddWithValue("@id", g.gID);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = Db.GetConnection();
            con.Open();
            const string sql = "DELETE FROM Gehege WHERE gID=@id";
            using var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        public List<Gehege> GetOhnePfleger()
        {
            var list = new List<Gehege>();
            using var con = Db.GetConnection();
            con.Open();

            using var cmd = new MySqlCommand(@"
        SELECT gID, GBezeichnung, KontinentID
        FROM Gehege g
        LEFT JOIN betreut b ON b.GehegeID = g.gID
        WHERE b.GehegeID IS NULL", con);

            using var r = cmd.ExecuteReader();
            while (r.Read())
                list.Add(MapGehege(r));

            return list;
        }

        public List<Gehege> GetOhneHauptpfleger()
        {
            var list = new List<Gehege>();
            using var con = Db.GetConnection();
            con.Open();

            using var cmd = new MySqlCommand(@"
        SELECT gID, GBezeichnung, KontinentID
        FROM Gehege
        WHERE gID NOT IN (
            SELECT GehegeID FROM betreut WHERE Hauptpfleger = 1
        )", con);

            using var r = cmd.ExecuteReader();
            while (r.Read())
                list.Add(MapGehege(r));

            return list;
        }

        private Gehege MapGehege(MySqlDataReader r)
        {
            return new Gehege
            {
                gID = r.GetInt32("gID"),
                GBezeichnung = r.GetString("GBezeichnung"),
                KontinentID = r.GetInt32("KontinentID")
            };
        }


    }
}
