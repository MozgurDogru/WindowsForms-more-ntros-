using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursiveFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtInput.Text);
            lblOutput.Text = "Factorial:" + Factorial(number);
        }

        private int Factorial(int number)
        {
            if (number>1)
            {
                return number*Factorial(number-1);
            }
            else
            {
                return 1;
            }
        }
    }
}
