using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
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

        private void btnFact_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);

            int f = 1;

            for (int i = 2; i <= number; i++)
            {
                f *= i;
            }
            lblOutput.Text = "Result:" + f;
        }
    }
}
