﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Program
{
    public partial class Fm1 : Form
    {
        String Bttnvalue = "X";
        public Fm1()
        {
            InitializeComponent();
        }

        private void Bttn1_Click(object sender, EventArgs e)
        {
            if (Bttn1.Text == "")
            {
                Bttn1.Text = Bttnvalue;
                if (Bttnvalue == "X")
                {
                    Bttnvalue = "O";
                }
                else
                {
                    Bttnvalue = "X";
                }
                //Row Pattern
                if (Bttn1.Text == Bttn4.Text)
                {
                    if (Bttn4.Text == Bttn7.Text)
                    {
                        MessageBox.Show(Bttn1.Text + " Wins the Game");
                        Bttn1.Text = "";
                        Bttn2.Text = "";
                        Bttn3.Text = "";
                        Bttn4.Text = "";
                        Bttn5.Text = "";
                        Bttn6.Text = "";
                        Bttn7.Text = "";
                        Bttn8.Text = "";
                        Bttn9.Text = "";
                    }
                }
            }
        }

        private void Bttn2_Click(object sender, EventArgs e)
        {
            if (Bttn2.Text == "")
            {
                Bttn2.Text = Bttnvalue;
                if (Bttnvalue == "X")
                {
                    Bttnvalue = "O";
                }
                else
                {
                    Bttnvalue = "X";
                }
                //Row Pattern
                if (Bttn2.Text == Bttn5.Text)
                {
                    if (Bttn5.Text == Bttn8.Text)
                    {
                        MessageBox.Show(Bttn2.Text + " Wins the Game");
                        Bttn1.Text = "";
                        Bttn2.Text = "";
                        Bttn3.Text = "";
                        Bttn4.Text = "";
                        Bttn5.Text = "";
                        Bttn6.Text = "";
                        Bttn7.Text = "";
                        Bttn8.Text = "";
                        Bttn9.Text = "";
                    }
                }
            }
        }

        private void Bttn3_Click(object sender, EventArgs e)
        {
            if (Bttn3.Text == "")
            {
                Bttn3.Text = Bttnvalue;
                if (Bttnvalue == "X")
                {
                    Bttnvalue = "O";
                }
                else
                {
                    Bttnvalue = "X";
                }
                //Row Pattern
                if (Bttn3.Text == Bttn6.Text)
                {
                    if (Bttn6.Text == Bttn9.Text)
                    {
                        MessageBox.Show(Bttn3.Text + " Wins the Game");
                        Bttn1.Text = "";
                        Bttn2.Text = "";
                        Bttn3.Text = "";
                        Bttn4.Text = "";
                        Bttn5.Text = "";
                        Bttn6.Text = "";
                        Bttn7.Text = "";
                        Bttn8.Text = "";
                        Bttn9.Text = "";
                    }
                }
            }
        }

        private void Bttn4_Click(object sender, EventArgs e)
        {
            if (Bttn4.Text == "")
            {
                Bttn4.Text = Bttnvalue;
                if (Bttnvalue == "X")
                {
                    Bttnvalue = "O";
                }
                else
                {
                    Bttnvalue = "X";
                }
                //Row Pattern
                if (Bttn4.Text == Bttn7.Text)
                {
                    if (Bttn7.Text == Bttn1.Text)
                    {
                        MessageBox.Show(Bttn4.Text + " Wins the Game");
                        Bttn1.Text = "";
                        Bttn2.Text = "";
                        Bttn3.Text = "";
                        Bttn4.Text = "";
                        Bttn5.Text = "";
                        Bttn6.Text = "";
                        Bttn7.Text = "";
                        Bttn8.Text = "";
                        Bttn9.Text = "";
                    }
                }
            }
        }

        private void Bttn5_Click(object sender, EventArgs e)
        {
            if (Bttn5.Text == "")
            {
                Bttn5.Text = Bttnvalue;
                if (Bttnvalue == "X")
                {
                    Bttnvalue = "O";
                }
                else
                {
                    Bttnvalue = "X";
                }
                //Row Pattern
                if (Bttn5.Text == Bttn8.Text)
                {
                    if (Bttn8.Text == Bttn2.Text)
                    {
                        MessageBox.Show(Bttn5.Text + " Wins the Game");
                        Bttn1.Text = "";
                        Bttn2.Text = "";
                        Bttn3.Text = "";
                        Bttn4.Text = "";
                        Bttn5.Text = "";
                        Bttn6.Text = "";
                        Bttn7.Text = "";
                        Bttn8.Text = "";
                        Bttn9.Text = "";
                    }
                }

            }
        }

        private void Bttn6_Click(object sender, EventArgs e)
        {
            if (Bttn6.Text == "")
            {
                Bttn6.Text = Bttnvalue;
                if (Bttnvalue == "X")
                {
                    Bttnvalue = "O";
                }
                else
                {
                    Bttnvalue = "X";
                }
                //Row Pattern
                if (Bttn6.Text == Bttn9.Text)
                {
                    if (Bttn9.Text == Bttn3.Text)
                    {
                        MessageBox.Show(Bttn6.Text + " Wins the Game");
                        Bttn1.Text = "";
                        Bttn2.Text = "";
                        Bttn3.Text = "";
                        Bttn4.Text = "";
                        Bttn5.Text = "";
                        Bttn6.Text = "";
                        Bttn7.Text = "";
                        Bttn8.Text = "";
                        Bttn9.Text = "";
                    }
                }
            }
        }

        private void Bttn7_Click(object sender, EventArgs e)
        {
            if (Bttn7.Text == "")
            {
                Bttn7.Text = Bttnvalue;
                if (Bttnvalue == "X")
                {
                    Bttnvalue = "O";
                }
                else
                {
                    Bttnvalue = "X";
                }
                //Row Pattern
                if (Bttn7.Text == Bttn4.Text)
                {
                    if (Bttn4.Text == Bttn1.Text)
                    {
                        MessageBox.Show(Bttn7.Text + " Wins the Game");
                        Bttn1.Text = "";
                        Bttn2.Text = "";
                        Bttn3.Text = "";
                        Bttn4.Text = "";
                        Bttn5.Text = "";
                        Bttn6.Text = "";
                        Bttn7.Text = "";
                        Bttn8.Text = "";
                        Bttn9.Text = "";
                    }
                }
            }
        }
        private void Bttn8_Click(object sender, EventArgs e)
        {
            if (Bttn8.Text == "")
            {
                Bttn8.Text = Bttnvalue;
                if (Bttnvalue == "X")
                {
                    Bttnvalue = "O";
                }
                else
                {
                    Bttnvalue = "X";
                }
                //Row Pattern
                if (Bttn8.Text == Bttn5.Text)
                {
                    if (Bttn5.Text == Bttn2.Text)
                    {
                        MessageBox.Show(Bttn8.Text + " Wins the Game");
                        Bttn1.Text = "";
                        Bttn2.Text = "";
                        Bttn3.Text = "";
                        Bttn4.Text = "";
                        Bttn5.Text = "";
                        Bttn6.Text = "";
                        Bttn7.Text = "";
                        Bttn8.Text = "";
                        Bttn9.Text = "";
                    }
                }
            }
        }
        private void Bttn9_Click(object sender, EventArgs e)
        {
            if (Bttn9.Text == "")
            {
                Bttn9.Text = Bttnvalue;
                if (Bttnvalue == "X")
                {
                    Bttnvalue = "O";
                }
                else
                {
                    Bttnvalue = "X";
                }
                //Row Pattern
                if (Bttn9.Text == Bttn6.Text)
                {
                    if (Bttn6.Text == Bttn3.Text)
                    {
                        MessageBox.Show(Bttn9.Text + " Wins the Game");
                        Bttn1.Text = "";
                        Bttn2.Text = "";
                        Bttn3.Text = "";
                        Bttn4.Text = "";
                        Bttn5.Text = "";
                        Bttn6.Text = "";
                        Bttn7.Text = "";
                        Bttn8.Text = "";
                        Bttn9.Text = "";
                    }
                }
            }
        }

        private void Rst_Click(object sender, EventArgs e)
        {
            Bttn1.Text = "";
            Bttn2.Text = "";
            Bttn3.Text = "";
            Bttn4.Text = "";
            Bttn5.Text = "";
            Bttn6.Text = "";
            Bttn7.Text = "";
            Bttn8.Text = "";
            Bttn9.Text = "";
        }

        private void Ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
