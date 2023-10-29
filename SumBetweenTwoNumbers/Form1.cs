using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumBetweenTwoNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            int sum = 0, temp;

            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }
            sum = NewMethod(num1, num2, sum);
        }

        private int NewMethod(int num1, int num2, int sum)
        {
            return NewMethod1(num1, num2, ref sum);
        }

        private int NewMethod1(int num1, int num2, ref int sum)
        {
            return SumNumbers(num1, num2, ref sum);
        }

        private int SumNumbers(int num1, int num2, ref int sum)
        {
            for (int i = num1; i <= num2; i++)
            {
                sum += i;
            }
            lblSum.Text = "Sum:" + sum;
            return sum;
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
