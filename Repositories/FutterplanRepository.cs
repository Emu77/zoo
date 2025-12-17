using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Zooverwaltung;
using Zooverwaltung.Models;
using var con = Db.GetConnection();


namespace Zooverwaltung.Repositories
{
    public class FutterplanRepository
    {
        private const string ConnectionString =
            "server=localhost;database=zoo;uid=root;pwd=;";

        public List<FutterplanEintrag> GetOverview(int tierId = 0)
        {
            var list = new List<FutterplanEintrag>();

            string sql = @"
                SELECT 
                    t.TierID,
                    t.Name AS TierName,
                    f.FutterID,
                    f.Bezeichnung AS FutterName,
                    r.Menge,
                    r.Uhrzeit,
                    r.Datum
                FROM futterrationen r
                JOIN tiere t ON t.TierID = r.TierID
                JOIN futter f ON f.FutterID = r.FutterID
                /**WHERE**/
                ORDER BY r.Datum DESC, r.Uhrzeit ASC
            ";

            if (tierId > 0)
                sql = sql.Replace("/**WHERE**/", "WHERE r.TierID = @tid");
            else
                sql = sql.Replace("/**WHERE**/", "");

            using (var con = new MySqlConnection(ConnectionString))
            using (var cmd = new MySqlCommand(sql, con))
            {
                if (tierId > 0)
                    cmd.Parameters.AddWithValue("@tid", tierId);

                con.Open();

                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        list.Add(new FutterplanEintrag
                        {
                            TierID = rd.GetInt32("TierID"),
                            TierName = rd.GetString("TierName"),
                            FutterID = rd.GetInt32("FutterID"),
                            FutterName = rd.GetString("FutterName"),
                            Menge = rd.GetString("Menge"),
                            Uhrzeit = rd.GetTimeSpan("Uhrzeit"),
                            Datum = rd.GetDateTime("Datum")
                        });
                    }
                }
            }

            return list;
        }
    }
}


