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

namespace WindowsFormsOrszagok
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView_Orszagok.ColumnCount = 3;
            dataGridView_Orszagok.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Orszagok.Columns[0].Name = "orszag_neve";
            dataGridView_Orszagok.Columns[0].HeaderText = "Ország neve";
            dataGridView_Orszagok.Columns[1].Name = "fovaros";
            dataGridView_Orszagok.Columns[1].HeaderText = "Főváros";
            dataGridView_Orszagok.Columns[2].Name = "terulet";
            dataGridView_Orszagok.Columns[2].HeaderText = "Terület";

            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "orszagok";
            connection = new MySqlConnection(sb.ToString());
            try
            {
                connection.Open();
                sql = connection.CreateCommand();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                Environment.Exit(0);
                throw;
            }
            sql.CommandText = "SELECT `orszag`,`fovaros`,`terulet` FROM `orszagok` WHERE 1";
            using (MySqlDataReader dr=sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    //új adatsor
                    int uj_sor_indexe = dataGridView_Orszagok.Rows.Add();
                    //már formázott sor
                    DataGridViewRow uj_sor = dataGridView_Orszagok.Rows
                        [uj_sor_indexe];
                    uj_sor.Cells["orszag_neve"].Value=dr.GetString("orszag");
                    uj_sor.Cells["fovaros"].Value = dr.GetString("fovaros");
                    uj_sor.Cells["terulet"].Value = dr.GetDouble("terulet");
                }
            }

        }
    }
}
