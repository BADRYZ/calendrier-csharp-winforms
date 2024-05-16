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
using MySql.Data.MySqlClient;

namespace cal
{
    
    public partial class ucdays : UserControl
    {
        public static string g_day;
        private string _day;

        public ucdays(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = _day;

            // Assurer que le clic sur le label ou le panel déclenche également l'événement
            this.Click += ucdays_Click;
            label1.Click += ucdays_Click;  // Assurez-vous que le clic sur le label est capturé
            panel1.Click += ucdays_Click;  // Et aussi le panel si nécessaire
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Cet événement est probablement vide si vous n'avez pas de logique de dessin spécifique.
        }

        private void ucdays_Click(object sender, EventArgs e)
        {
            g_day = _day; // Mettre à jour la journée globale si nécessaire
            ajouter formAjouter = new ajouter(_day, Form1._month, Form1._year);
            formAjouter.ShowDialog(); // Utiliser ShowDialog pour une fenêtre modale
            displayR();
        }
        private const string connString = "server=localhost;user id=root;password=;database=restoensa";
        private void displayR()
        {
            string connString = "server=localhost;user id=root;password=;database=restoensa";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                string sql = "SELECT serveur.nom, shift_serveur.id_shift, shift_serveur.date FROM serveur JOIN shift_serveur ON serveur.id = shift_serveur.id_serveur WHERE shift_serveur.date = CURDATE() ORDER BY serveur.nom";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                StringBuilder displayText = new StringBuilder();

                while (reader.Read())
                {
                    string serveurNom = reader["nom"].ToString();
                    int shiftId = Convert.ToInt32(reader["id_shift"]);
                    displayText.AppendLine($"{serveurNom}-{shiftId}");
                }

                display.Text = displayText.ToString();

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
