using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestU
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        
        int winsPlayer1 = 0;
        int winsPlayer2 = 0;
        int draws = 0;
        int l = 0;
        int trick = 0;
        
        public Form1()
        {
            InitializeComponent();
            checkForWinner();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Chris", "Tic Tac Toe About");

        }

        private void exitToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {


            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "0";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "0";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "0";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "0";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "0";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "0";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "0";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "0";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "0";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }
        private void checkForWinner()
        {
            bool tIAW = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                tIAW = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                tIAW = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                tIAW = true;
            }
            //vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                tIAW = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                tIAW = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                tIAW = true;
            }
            //cross checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                tIAW = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                tIAW = true;
            }

            else if (turn_count == 9)
            {
                MessageBox.Show("Draw !", "Bummer");
                draws++;
                Draws.Text = "Draws: " + draws;
                clear();
                //   disableButtons();
            }

            if (tIAW)
            {
                String winner = "";
                if (turn)
                {
                    winner = label1.Text + " which is O";
                    winsPlayer1++;
                    Player1Wins.Text = "Wins: " + winsPlayer1;
                }
                else
                {
                    winner = label2.Text + " which is X";
                    winsPlayer2++;
                    Player2wins.Text = "Wins: " + winsPlayer2;
                }

                MessageBox.Show(winner + " Wins!", "Yay!");
                // disableButtons();
                clear();
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
        private void clear()
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is Button)
                {
                    Button inputButton = c as Button;
                    if (inputButton != null)
                    {
                        inputButton.Text = "";
                        inputButton.Enabled = true;
                    }
                }

                
            }
            turn_count = 0;
            
        }
        private void ClearTicTac_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (trick == 0)
            {
                if (e.KeyCode == Keys.Enter && l == 0)
                {

                    label1.Text = textBox1.Text;
                    foreach (Control c in panel2.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox inputButton = c as TextBox;
                            if (inputButton != null)
                            {
                                inputButton.Text = "";
                                inputButton.Enabled = true;
                            }
                        }


                    }
                    l++;
                }
                else if (e.KeyCode == Keys.Enter && l == 1)
                {
                    label2.Text = textBox1.Text;
                    foreach (Control c in panel2.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox inputButton = c as TextBox;
                            if (inputButton != null)
                            {
                                inputButton.Text = "";
                                inputButton.Enabled = true;
                            }
                        }


                    }
                    l--;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Draws_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            trick = 2;
            UnlockNames.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void UnlockNames_Click(object sender, EventArgs e)
        {
            trick = 0;
            panel2.Visible = true;
            if (trick == 0) {
                UnlockNames.Visible = false;
            }
        }

        private void FormPageSwap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}

    
