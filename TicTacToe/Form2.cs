using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeWhatever
{
    public partial class Form1 : Form
    {
        public int spieler = 2;
        public int zug = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        bool isDraw()
        {
            if ((zug == 9) && isWinner() == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool isWinner()
        {
            // horizontal 
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && A3.Text != "")
                return true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && B3.Text != "")
                return true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && C3.Text != "")
                return true;
            // vertikal
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && C1.Text != "")
                return true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && C2.Text != "")
                return true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && C3.Text != "")
                return true;
            // diagonal
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && C3.Text != "")
                return true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && C1.Text != "")
                return true;
            else
                return false;

        }

        


        public Form1()
        {
            InitializeComponent();
        }

        private void gleichstand_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anzeigeX.Text = "X: " + s1;
            anzeigeY.Text = "Y: " + s1;
        }

        private void buttonsClick(object sender, EventArgs e)
        {
            Button button = (Button) sender; 

            if (button.Text == "")
            {
                if (spieler % 2 == 0)
                {
                    button.Text = "X";
                    spieler++;
                    zug++;
                }
                else
                {
                    button.Text = "O";
                    spieler++;
                    zug++;
                }
                if (isDraw() == true)
                {
                    MessageBox.Show("Unentschieden");
                    sd++;
                    NeuesSpiel();
                }
                if (isWinner() == true)
                {
                    if(button.Text == "X")
                    {
                        MessageBox.Show("X hat gewonnen");
                        s1++;
                        NeuesSpiel();
                    }
                    else
                    {
                        MessageBox.Show("Y hat gewonnen");
                        s2++;
                        NeuesSpiel();
                    }
                }
            }
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
            anzeigeX.Text = "X: " + s1;
            anzeigeY.Text = "Y: " + s2;
        }

        public void NeuesSpiel()
        {
            spieler = 2;
            zug = 0;
            A1.Text = A2.Text = A3.Text = B1.Text = B2.Text = B3.Text = C1.Text = C2.Text = C3.Text = "";


            anzeigeX.Text = "X: " + s1;
            anzeigeY.Text = "Y: " + s2;
            anzeigeGleichstand.Text = "Gleichstand: " + sd;

        }
        private void reset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NeuesSpiel();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
