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
        private string _day;
        private string date;  
        private string weekday;
        public ucdays(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = _day;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
