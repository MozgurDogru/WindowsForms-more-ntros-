using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetControls();
            StartRace();
            DisplayMessage();
        }

        private void DisplayMessage()
        {
            if (pbxBlack.Left>pbxWhite.Left)
            {
                MessageBox.Show("Bold pilot WIN!");
            }
            else if (pbxWhite.Left>pbxBlack.Left) 
            {
                MessageBox.Show("White Angel WIN!");
            }
            else 
            {
                MessageBox.Show("Friendly WIN!");
            }
        }

        private void ResetControls()
        {
            pbxBlack.Left = pbxWhite.Left = 30;
        }

        private void StartRace()
        {
            Random rnd = new Random();

            do
            {
                pbxBlack.Left += rnd.Next(10);
                pbxWhite.Left += rnd.Next(10);
                System.Threading.Thread.Sleep(85);

            } while (pbxBlack.Width+pbxBlack.Left<btnFınısh.Left &&
            pbxWhite.Width + pbxWhite.Left < btnFınısh.Left);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
