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


namespace cal
{
    public partial class ajouter : Form
    {
        string connS = "server=localhost;user id=root;database=restoensa;sslmode=none";
        public ajouter()
        {
            InitializeComponent();
        }

        private void ajouter_Load(object sender, EventArgs e)
        {
            datefield.Text=ucdays.g_day+"/"+Form1._month+"/"+Form1._year;
        }
        public ajouter(string day, int month, int year)
        {
            InitializeComponent();
            datefield.Text = $"{day}/{month}/{year}";
        }

        private void btncommit_Click(object sender, EventArgs e)
        {
            /*MySqlConnection conn = new MySqlConnection(connS);
            conn.Open();
            string sql = "INSERT INTO shift_serveur (id_shift,id_serveur) VALUSES(?,?)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("id_shift",);
            cmd.Parameters.AddWithValue("id_serveur",);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bien");
            cmd.Dispose();
            conn.Close();*/
        }
    }
}
