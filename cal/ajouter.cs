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
        //string connS = "server=localhost;user id=root;passwrd=;database=restoensa";
        private const string connString = "server=localhost;user id=root;password=;database=restoensa";

        private void TestDatabaseConnection()
        {
            // Assurez-vous que la chaîne de connexion est correcte, notamment le port si nécessaire
            string connectionString = "server=localhost;port=3306;user id=root;password=;database=RestoEnsa";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();  // Tentative d'ouverture de la connexion
                    MessageBox.Show("Connexion à la base de données réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Affichage d'un message d'erreur en cas d'échec
                MessageBox.Show($"Erreur lors de la connexion à la base de données: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public ajouter()
        {
            InitializeComponent();
            
            

        }
        public class ComboBoxItem
        {
            public string Text { get; }
            public int Value { get; }

            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;  // Pour que le texte s'affiche correctement dans la ComboBox
            }
        }

        private void LoadServers()
        {
            string query = "SELECT id, nom FROM serveur";  // Requête SQL pour récupérer les serveurs
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();  // Ouvrir la connexion
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Nettoyer les éléments existants
                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        string serveurNom = reader["nom"].ToString();
                        int serveurId = Convert.ToInt32(reader["id"]);

                        // Ajouter le serveur à la ComboBox avec un objet qui contient l'ID et le nom
                        comboBox1.Items.Add(new ComboBoxItem(serveurNom, serveurId));
                    }

                    comboBox1.DisplayMember = "Text";  // Le champ à afficher
                    comboBox1.ValueMember = "Value";   // Le champ qui contient la valeur
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des serveurs : " + ex.Message);
                }
            }
        }




        private void LoadShifts()
        {
            // Vous pouvez définir les shifts comme des objets pour une gestion plus facile des données.
            comboBoxShifts.Items.Clear();  // Nettoyer les éléments existants
            comboBoxShifts.Items.Add(new ComboBoxItem("Shift 1", 1));
            comboBoxShifts.Items.Add(new ComboBoxItem("Shift 2", 2));

            comboBoxShifts.DisplayMember = "Text";
            comboBoxShifts.ValueMember = "Value";
        }

        private void ajouter_Load(object sender, EventArgs e)
        {
            LoadServers();
            LoadShifts();
            datefield.Text=ucdays.g_day+"/"+Form1._month+"/"+Form1._year;
        }
        public ajouter(string day, int month, int year)
        {
            InitializeComponent();
            datefield.Text = $"{day}/{month}/{year}";
        }

        private void btncommit_Click(object sender, EventArgs e)
        {
            if (!(comboBox1.SelectedItem is ComboBoxItem selectedServeur))
            {
                MessageBox.Show("Veuillez sélectionner un serveur.");
                return;
            }
            int serveurId = selectedServeur.Value;

            if (!(comboBoxShifts.SelectedItem is ComboBoxItem selectedShift))
            {
                MessageBox.Show("Veuillez sélectionner un shift.");
                return;
            }
            int shiftId = selectedShift.Value;

            if (!DateTime.TryParse(datefield.Text, out DateTime selectedDate))
            {
                MessageBox.Show("Format de date invalide.");
                return;
            }

            string connString = "server=localhost;user id=root;password=;database=restoensa";
            string query = "INSERT INTO shift_serveur (id_shift, id_serveur, date) VALUES (@id_shift, @id_serveur, @date)";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_shift", shiftId);
                        cmd.Parameters.AddWithValue("@id_serveur", serveurId);
                        cmd.Parameters.AddWithValue("@date", selectedDate);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Données insérées avec succès.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'insertion des données : " + ex.Message);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
