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
    public partial class Ristinolla1 : Form
    {
        public Ristinolla1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { // Avaa uuden formin jos painaa button1
            Ristinolla2 rs2 = new Ristinolla2();
            rs2.Show();
            Visible = false;
            
        }

        private void Nappi2_Click(object sender, EventArgs e)
        { //avaa uuden formin jos painaa nappi2
            Ristinolla3 rs3 = new Ristinolla3();
            rs3.Show();
            Visible = false;
        }
    }
}
