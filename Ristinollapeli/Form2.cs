using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristinollapeli
{
    public partial class Ristinolla2 : Form
    {
        public Ristinolla2()
        {
            InitializeComponent();
        }

        private void Ristinolla2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ristinolla5 rs5 = new Ristinolla5();
            rs5.Show();
            Visible = false;

            Ristinolla5.Pelaajannimi(enimibox.Text);

           
        }
    }
}
