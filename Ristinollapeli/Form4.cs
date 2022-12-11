using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ristinollapeli
{
    public partial class Ristinolla4 : Form
    {
        bool turn = true; // jos on tosi on x vuoro ja jos on epätosi on o vuoro
        int turn_count = 0;
        static String pelaaja1, pelaaja2;
        public Ristinolla4()
        {
            InitializeComponent();
        }
        public static void Pelaajiennimet(String p1, String p2)
        {
            pelaaja1 = p1;
            pelaaja2 = p2;
        }

        private void Ristinolla4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();  //sulkee ohjelman jos painaa rastia
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)   // jos ehto on tosi niin napin clikkaus kirjoittaa X kirjaimen
                b.Text = "X";
            else        // jos ehto on epätosi niin napin clikkaus kirjoittaa O kirjaimen
                b.Text = "O";

            turn = !turn;
            b.Enabled = false; // Muuttaa X ja O harmaaksi
            turn_count++;

            tarkistaavoittajan();
        }
        private void tarkistaavoittajan()
        {
            bool voittajaon = false; // Voittaja on epätosi

            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled))
                voittajaon = true;  // voittaja on tosi jos btn1, btn2 ja btn3 on sama kirjain
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
                voittajaon = true;  // voittaja on tosi jos btn4, btn5 ja btn6 on sama kirjain
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
                voittajaon = true;// voittaja on tosi jos btn7, btn8 ja btn9 on sama kirjain

            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
                voittajaon = true;  // voittaja on tosi jos btn1, btn4 ja btn7 on sama kirjain
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
                voittajaon = true;  // voittaja on tosi jos btn2, btn5 ja btn8 on sama kirjain
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
                voittajaon = true;// voittaja on tosi jos btn3, btn6 ja btn9 on sama kirjain

            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
                voittajaon = true;  // voittaja on tosi jos btn1, btn5 ja btn9 on sama kirjain
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn7.Enabled))
                voittajaon = true;  // voittaja on tosi jos btn3, btn5 ja btn7 on sama kirjain


            if (voittajaon)     // Ilmoittaa voittajan nimen tekstiboksilla ja kysyy haluatko pelata uudestaan
            {
                disableButtons();

                String voittaja = "";
                if (turn)
                {
                    voittaja = pelaaja2;
                    Pel2luku.Text = (Int32.Parse(Pel2luku.Text) + 1).ToString();
                }
                else
                {
                    voittaja = pelaaja1;
                    Pel1luku.Text = (Int32.Parse(Pel2luku.Text) + 1).ToString();
                }


                DialogResult result = MessageBox.Show(voittaja + " Voitti pelin! halutko pelata uudestaan?", "Peli päättyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);   // ilmoitetaan voittaja eri ikkunassa
                if (result == DialogResult.Yes)
                {
                    turn = true;
                    turn_count = 0;

                    foreach (Control c in Controls)
                    {
                        try
                        {
                            Button b = (Button)c;
                            b.Enabled = true;
                            b.Text = "";
                        }
                        catch { }
                    }
                }
                else
                {
                    Application.Exit();
                }

            }
            else
            {
                if (turn_count == 9)       //tasapeli
                {
                    Tasapluku.Text = (Int32.Parse(Tasapluku.Text) + 1).ToString();
                    DialogResult result = MessageBox.Show("Tasepeli! Haluatko pelata uudestaan?", "Peli päättyi.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        turn = true;
                        turn_count = 0;

                        foreach (Control c in Controls)
                        {
                            try
                            {
                                Button b = (Button)c;
                                b.Enabled = true;
                                b.Text = "";
                            }
                            catch { }
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                    
                }
            }

        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }



        private void TSMuusipeli_Click_1(object sender, EventArgs e)
        {
            // Aloittaa uuden pelin kun valitsee tiedostosta "uusi peli"

            turn = true;
            turn_count = 0;

           
            
            foreach (Control c in Controls)
            {
                 try
                 {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                 }
                catch { }
            }


            
            

        }

        private void TSMlopeta_Click(object sender, EventArgs e)
        {
            Application.Exit();    // jos valikosta valitsee lopeta niin sulkee koko ohjelman
        }

        private void button_enter(object sender, EventArgs e) // ilmoittaa kenen vuoro on
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    Vuorolabel.Text = pelaaja1 + " vuoro";
                else
                    Vuorolabel.Text = pelaaja2 + " vuoro";


            }
        }

        private void Ristinolla4_Load(object sender, EventArgs e)
        {
            
            Pel1voi.Text = pelaaja1;
            Pel2voi.Text = pelaaja2;
        }

        private void TSMohje_Click(object sender, EventArgs e) // jos valikosta valitsee "ohje" niin avaa wikipediasta ristonollan ohjeet
        {
            System.Diagnostics.Process.Start("https://fi.wikipedia.org/wiki/Ristinolla");
        }

        

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                Vuorolabel.Text = "";
            }

        }


    }
}
