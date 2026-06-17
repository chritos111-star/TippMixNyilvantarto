using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TippMixNyilvantarto;

namespace TippMixNyilvantarto
{
    public partial class Form1 : Form
    {
        List<Meccs> meccsek = new List<Meccs>();
        public Form1()
        {
            
            
            InitializeComponent();
           
            cmBoxTipp.Items.Add("1");
            cmBoxTipp.Items.Add("X");
            cmBoxTipp.Items.Add("2");
            cmBoxTipp.Items.Add("BTTS");
        }
        
        szelveny szelveny = new szelveny();
        CsapatRepository repo = new CsapatRepository();
        private void btnKapcsolat_Click(object sender, EventArgs e)
        {
            string kapcsolat =
        "server=localhost;database=gyakorlo_db;uid=root;pwd=22Chritos22+;";

            MySqlConnection conn = new MySqlConnection(kapcsolat);

            try
            {
                conn.Open();
                MessageBox.Show("Sikeres kapcsolat!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            bool btts = checkBox1.Checked;
            string kapcsolat =
                "server=localhost;database=gyakorlo_db;uid=root;pwd=22Chritos22+;";

            MySqlConnection conn = new MySqlConnection(kapcsolat);

            try
            {
                conn.Open();

                string sql = @"
                    INSERT INTO Meccsek
                    (HazaiCsapatId, VendegCsapatId, Datum, Odds, BTTS, BTTSOdds, TippTipus)
                    VALUES
                    (@hazai, @vendeg, NOW(), @odds, @btts, @bttsodds, @tipptipus)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@hazai",
                    Convert.ToInt32(txtHazaiId.Text));

                cmd.Parameters.AddWithValue("@vendeg",
                    Convert.ToInt32(txtVendegId.Text));

                

                cmd.Parameters.AddWithValue("@odds",
                    Convert.ToDouble(txtOdds.Text));

                cmd.Parameters.AddWithValue("@btts",
                    checkBox1.Checked);
                cmd.Parameters.AddWithValue("@bttsodds", Convert.ToDouble(txtBttsOdds.Text));
                cmd.Parameters.AddWithValue("@tipptipus",
                cmBoxTipp.SelectedItem.ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Meccs hozzáadva!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        private void btnLista_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Listázva");
            string kapcsolat =
            "server=localhost;database=gyakorlo_db;uid=root;pwd=22Chritos22+;";

            MySqlConnection conn = new MySqlConnection(kapcsolat);
            
            try
            {
                conn.Open();

                string sql = @"
                SELECT 
                    m.Id,
                    hc.Nev AS Hazai,
                    vc.Nev AS Vendeg,
                    m.Odds,
                    m.TippTipus,
                    m.BTTSOdds
                FROM Meccsek m
                JOIN Csapatok hc ON m.HazaiCsapatId = hc.Id
                JOIN Csapatok vc ON m.VendegCsapatId = vc.Id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                dataGridView1.DataSource = tabla;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            string kapcsolat =
                 "server=localhost;database=gyakorlo_db;uid=root;pwd=22Chritos22+;";

            MySqlConnection conn = new MySqlConnection(kapcsolat);

            try
            {
                conn.Open();

                int id =
                    Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                string sql = "DELETE FROM Meccsek WHERE Id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sikeres törlés!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNev.Text = "";
            txtOrszag.Text = "";
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            string kapcsolat =
    "server=localhost;database=gyakorlo_db;uid=root;pwd=22Chritos22+;";

            MySqlConnection conn = new MySqlConnection(kapcsolat);

            try
            {
                conn.Open();

                int id =
                    Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                string sql =
                    "UPDATE Meccsek SET Odds=@odds, BTTS=@btts WHERE Id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@odds",
                    Convert.ToDouble(txtOdds.Text));

                cmd.Parameters.AddWithValue("@btts",
                    checkBox1.Checked);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sikeres módosítás!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmBoxTipp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         bool btts = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btts = checkBox1.Checked;
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            double tet = Convert.ToDouble(textTet.Text);

            List<Meccs> meccsek = new List<Meccs>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Odds"].Value != null && row.Cells["Odds"].Value != DBNull.Value)
                {
                    meccsek.Add(new Meccs
                    {
                        Odds = Convert.ToDouble(row.Cells["Odds"].Value)
                    });
                }
            }

            double osszOdds = OsszOdds(meccsek);
            double nyeremeny = tet * osszOdds;

            MessageBox.Show("Nyeremény: " + nyeremeny);

        }

        public double OsszOdds(List<Meccs> meccsek)
        {
            if (meccsek == null || meccsek.Count == 0)
                return 0;

            double szorzo = 1;

            foreach (var m in meccsek)
            {
                szorzo *= m.Odds;
            }

            return szorzo;
        }

        private void btncsapathozzaad_Click(object sender, EventArgs e)
        {
            string kapcsolat =
    "server=localhost;database=gyakorlo_db;uid=root;pwd=22Chritos22+;";

            MySqlConnection conn = new MySqlConnection(kapcsolat);

            try
            {
                conn.Open();

                string sql =
                "INSERT INTO Csapatok(Nev, Orszag) VALUES(@nev, @orszag)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nev", txtNev.Text);
                cmd.Parameters.AddWithValue("@orszag", txtOrszag.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Csapat hozzáadva!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
