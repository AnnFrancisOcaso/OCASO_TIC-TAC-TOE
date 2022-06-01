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
    public partial class TICTACTOE : Form
    {

        bool turn = true;
        // true = X turn; false = Y turn
        int countingofturns = 0;

        public TICTACTOE()
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
            bttn.Enabled = false;

            CheckForWinner();
        }

        private void CheckForWinner()
        {

            bool we_have_a_winner = false;

            //horizontal check for winner
            if ((R1.Text == R2.Text) && (R2.Text == R3.Text) && (!R1.Enabled));
                we_have_a_winner = true;
            if ((S1.Text == S2.Text) && (S2.Text == S3.Text) && (!S1.Enabled));
                we_have_a_winner = true;
            if ((T1.Text == T2.Text) && (T2.Text == T3.Text) && (!T1.Enabled));
                we_have_a_winner = true;

            if (we_have_a_winner)
            {
                String winner = "";
                if (turn)
                    winner = "X";
                else
                    winner = "O";

                MessageBox.Show("We have a Winner!", "Congratulations!");
            } // end if


        } //end checkforwinner

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Restartbttn_Click(object sender, EventArgs e)
        {

        }
    }
}
