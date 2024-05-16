using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
