using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRaceWithTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetControls();
            timer1.Start();
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbxBlack.Left += rnd.Next(10);
            pbxWhite.Left += rnd.Next(10);
            pbxBrown.Left += rnd.Next(10);

            if (pbxBlack.Left + pbxBlack.Width >= btnFınısh.Left || pbxWhite.Left + pbxWhite.Width >= btnFınısh.Left || pbxBrown.Left + pbxBrown.Width >= btnFınısh.Left)
            {
                timer1.Stop();
                displayMessage();
            }

        }

        private void displayMessage()
        {
            if (pbxBlack.Left > pbxBrown.Left && pbxBlack.Left > pbxWhite.Left)
            {
                MessageBox.Show("Bold Pilot WIN!");
            }
            else if (pbxWhite.Left > pbxBlack.Left && pbxWhite.Left > pbxBrown.Left)
            {
                MessageBox.Show("White Angel WIN!");
            }
            else if (pbxBrown.Left > pbxBlack.Left && pbxBrown.Left > pbxWhite.Left)
            {
                MessageBox.Show("Mirhat WIN!");
            }

            else
            {
                MessageBox.Show("Friendly WIN!");
            }
            ResetControls();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ResetControls()
        {
            pbxBlack.Left = pbxWhite.Left = pbxBrown.Left = 30;
            timer1.Stop();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnBreak.Text = "Continue";
            }
            else
            {
                timer1.Start();
                btnBreak.Text = "BREAK";
            }
        }
    }
}
