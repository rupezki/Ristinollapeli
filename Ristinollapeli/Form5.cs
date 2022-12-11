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
    public partial class Ristinolla5 : Form
    {
        bool turn = true;
        bool tietokonetta_vastaan = true;
        int turn_count = 0;
        static String pelaaja;
        public Ristinolla5()
        {
            InitializeComponent();
        }
         
        public static void Pelaajannimi(string p)
        {
            pelaaja = p;
        }

         private void Ristinolla5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //sulkee ohjelman jos painaa rastia
        }

       

        private void button_click(object sender, EventArgs e)
        {
            if ((P.Text == "pelaaja 1") || (Konevoi.Text == "pelaaja 2"))
            {
                MessageBox.Show("");
            }
            else
            {
                Button b = (Button)sender;
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";

                turn = !turn;
                b.Enabled = false;
                turn_count++;

                //tasapelit.Focus();
                tarkistaavoittajan();

                
            }
             

            if ((!turn) && (tietokonetta_vastaan))
            {
                computer_make_move();
            }
        }

        private void computer_make_move()
        {
            Button move = null;

            move = look_for_win_or_block("O");
            if (move == null)
            {
                move = look_for_win_or_block("X");
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }
                }
            }

            move.PerformClick();
            {
                
            }
        }

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }

            return null;
        }
        private Button look_for_corner() // Tietokoneen siirto mahdollisuudet
        {
            Console.WriteLine("Looking for corner");
            if (btn1.Text == "O")
            {
                if (btn3.Text == "")
                    return btn3;
                if (btn9.Text == "")
                    return btn9;
                if (btn7.Text == "")
                    return btn7;

            }

            if (btn3.Text == "O")
            {
                if (btn1.Text == "")
                    return btn1;
                if (btn9.Text == "")
                    return btn9;
                if (btn7.Text == "")
                    return btn7;
            }

            if(btn9.Text == "O")
            {
                if (btn1.Text == "")
                    return btn3;
                if (btn3.Text == "")
                    return btn3;
                if (btn7.Text == "")
                    return btn7;
            }

            if (btn7.Text == "O")
            {
                if (btn1.Text == "")
                    return btn3;
                if (btn3.Text == "")
                    return btn3;
                if (btn9.Text == "")
                    return btn9;
            }

            if (btn1.Text == "")
                return btn1;
            if (btn3.Text == "")
                return btn3;
            if (btn7.Text == "")
                return btn7;
            if (btn9.Text == "")
                return btn9;
             
            return null;
        }

        private Button look_for_win_or_block(string mark)
        { // tietokone etsii voittomahdollisuutta
            
            Console.WriteLine("Looking for win or block " + mark);

            if ((btn1.Text == mark) && (btn2.Text == mark) && (btn3.Text == ""))
                return btn3;
            if ((btn2.Text == mark) && (btn3.Text == mark) && (btn1.Text == ""))
                return btn1;
            if ((btn1.Text == mark) && (btn3.Text == mark) && (btn2.Text == ""))
                return btn2;

            if ((btn4.Text == mark) && (btn5.Text == mark) && (btn6.Text == ""))
                return btn6;
            if ((btn5.Text == mark) && (btn6.Text == mark) && (btn4.Text == ""))
                return btn4;
            if ((btn4.Text == mark) && (btn6.Text == mark) && (btn5.Text == ""))
                return btn5;

            if ((btn7.Text == mark) && (btn8.Text == mark) && (btn9.Text == ""))
                return btn9;
            if ((btn8.Text == mark) && (btn9.Text == mark) && (btn7.Text == ""))
                return btn7;
            if ((btn7.Text == mark) && (btn9.Text == mark) && (btn8.Text == ""))
                return btn8;

            if ((btn1.Text == mark) && (btn4.Text == mark) && (btn7.Text == ""))
                return btn7;
            if ((btn4.Text == mark) && (btn7.Text == mark) && (btn1.Text == ""))
                return btn1;
            if ((btn1.Text == mark) && (btn7.Text == mark) && (btn4.Text == ""))
                return btn4;

            if ((btn2.Text == mark) && (btn5.Text == mark) && (btn8.Text == ""))
                return btn8;
            if ((btn5.Text == mark) && (btn8.Text == mark) && (btn2.Text == ""))
                return btn2;
            if ((btn2.Text == mark) && (btn8.Text == mark) && (btn5.Text == ""))
                return btn5;

            if ((btn3.Text == mark) && (btn6.Text == mark) && (btn9.Text == ""))
                return btn9;
            if ((btn6.Text == mark) && (btn9.Text == mark) && (btn3.Text == ""))
                return btn3;
            if ((btn3.Text == mark) && (btn9.Text == mark) && (btn6.Text == ""))
                return btn6;

            if ((btn1.Text == mark) && (btn5.Text == mark) && (btn9.Text == ""))
                return btn9;
            if ((btn5.Text == mark) && (btn9.Text == mark) && (btn1.Text == ""))
                return btn1;
            if ((btn1.Text == mark) && (btn9.Text == mark) && (btn5.Text == ""))
                return btn5;

            if ((btn3.Text == mark) && (btn5.Text == mark) && (btn7.Text == ""))
                return btn7;
            if ((btn5.Text == mark) && (btn7.Text == mark) && (btn3.Text == ""))
                return btn3;
            if ((btn3.Text == mark) && (btn7.Text == mark) && (btn5.Text == ""))
                return btn5;

            return null;

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

            if (voittajaon) //ilmoittaa voittajan teksiboksilla ja kysyy haluatko pelata uudestaan
            { 
                disableButtons();

                string voittaja = "";
                if (turn)
                {
                    voittaja = Konevoi.Text;
                    koneluku.Text = (Int32.Parse(koneluku.Text) + 1).ToString();
                }
                else
                {
                    voittaja = P.Text;
                    Pelluku.Text = (Int32.Parse(koneluku.Text) + 1).ToString();
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
                if (turn_count == 9)
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

        private void button_enter(object sender, EventArgs e)
        {   // ilmoittaa kenen vuoro on
            Button b = (Button)sender;
            if (b.Enabled)
            {
               if (turn)
                   Vuorolabel.Text = "pelaajan vuoro";
                else
                   Vuorolabel.Text = "Tietokoneen vuoro";

                
            }
        }

    

        private void Ristinolla5_Leave(object sender, EventArgs e)
        {   
            Button b = (Button)sender;
            if (b.Enabled)
            {
                Vuorolabel.Text = "";
            }
            
        }

        private void uusiPelitsm_Click(object sender, EventArgs e)
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

        private void Lopetatsm_Click(object sender, EventArgs e)
        { // jos valikosta valitsee "lopeta" niin sulkee ohjelman
            Application.Exit();
        }

        private void ohjetsm_Click(object sender, EventArgs e)
        { //jos valikosta valitsee "ohje" avaa ristinollan ohjeet wikipediasta
            System.Diagnostics.Process.Start("https://fi.wikipedia.org/wiki/Ristinolla");
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

        

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void Ristinolla5_Load(object sender, EventArgs e)
        {
            P.Text = pelaaja;
            
        }

        
    }
}
