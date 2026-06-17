using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TippMixNyilvantarto
{
    internal class CsapatRepository
    {
        private string connStr =
        "server=localhost;database=gyakorlo_db;uid=root;pwd=22Chritos22+;";

        public DataTable GetAll()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT * FROM Csapatok";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    throw new Exception("Adatbázis hiba: " + ex.Message);
                }

                return dt;
            }
            
        }
    }
}
