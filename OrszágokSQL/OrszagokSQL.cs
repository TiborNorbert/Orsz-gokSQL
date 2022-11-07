using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrszágokSQL
{
    public partial class OrszagokSQL : Form
    {
        public OrszagokSQL()
        {
            InitializeComponent();
        }

        private void OrszagokSQL_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orszagok";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT `id`,`orszag`,`fovaros`,`terulet`,`nepesseg`,`allamforma` FROM `orszagok` WHERE 1";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        OrszagAdatok orszag = new OrszagAdatok(dr.GetInt32("id"),dr.GetString("orszag"),dr.GetString("fovaros"),dr.GetDouble("terulet"), dr.GetDouble("nepesseg"),dr.GetString("allamforma"));
                        list_Orszagok.Items.Add(orszag);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message+Environment.NewLine+"A program leáll!");
                Environment.Exit(0);
            }
        }

        private void list_Orszagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Orszagok.SelectedIndex<0)
            {
                return;
            }
            OrszagAdatok kivalasztottOrszag=(OrszagAdatok) list_Orszagok.SelectedItem;
            textBox1.Text = kivalasztottOrszag.Id.ToString();
            orszag.Text = kivalasztottOrszag.OrszagNev;
            fovaros.Text= kivalasztottOrszag.Fovaros;
            terulet.Text = kivalasztottOrszag.Terulet.ToString("#,##0");
            nepesseg.Text = kivalasztottOrszag.Nepesseg.ToString("#,##0");
            allamforma.Text = kivalasztottOrszag.Allamforma;
        }
    }
}
