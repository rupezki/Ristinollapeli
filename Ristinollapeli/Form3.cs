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
    public partial class Ristinolla3 : Form
    {
        public Ristinolla3()
        {
            InitializeComponent();
        }

        private void Ristinolla3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // sulkee ohjelman jos painaa rastia
        }

        private void button1_Click(object sender, EventArgs e)
        { // avaa uuden formin
            Ristinolla4 rs4 = new Ristinolla4();
            rs4.Show();   
            Visible = false;

            Ristinolla4.Pelaajiennimet(Enimitbox.Text, Enimibox2.Text);
            
            
        }

        
    }
}
