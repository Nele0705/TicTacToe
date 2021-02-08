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
            if ((zug == 9) &&(isWinner() == false ))
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
            //horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && A1.Text != "")
                return true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && B3.Text != "")
                return true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && C3.Text != "")
                return true;
            // Vertikal 

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && C1.Text != "")
                return true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && C2.Text != "")
                return true;
            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && C3.Text != "")
                return true;
            // Diagonal
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
            lbl_Draw = "Draw: " + s1;
        }
    }
}
