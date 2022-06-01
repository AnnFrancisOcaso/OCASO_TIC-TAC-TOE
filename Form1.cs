using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocaso_tic_tac_toe
{
    public partial class Form1 : Form
    {
        
        bool turn = true;
        // true = X turn; false = Y turn
        int countingofturns = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutTheCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is created by Ann Francis Ocaso, a Computer Engineering Student in PUP Sta.Mesa.", "About the Creator");
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1) The game is played on a three-by-three-square grid. (2) Your friend is O, and you are X.Players take turns marking empty squares with their marks. (3) The winner is the first player to get three marks in a row (up, down, across, or diagonally). (4) The game is over when all 9 squares are filled.The game ends in a tie if no player has three consecutive marks.", "Rules for Tic-Tac-Toe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bttn = (Button)sender;
            if (turn)
                bttn.Text = "X";
            else
                bttn.Text = "O";

            turn = !turn;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
