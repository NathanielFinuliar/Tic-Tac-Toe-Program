using System;
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

            }
        }
    }
}
