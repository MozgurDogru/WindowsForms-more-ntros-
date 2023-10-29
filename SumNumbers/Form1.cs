using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            //int Result = num1+ num2;

            //lblResult.Text = "Result:" + Result;
            lblResult.Text = "Result:" + (num1 + num2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperator.Items.AddRange(new string[] { " Select ", "+", "-", "*", "/" });
            cmbOperator.SelectedIndex = 0;
        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text == string.Empty || txtNum2.Text == string.Empty)
            {
                return;
            }

            double Result;
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);

            #region if - else if
            //if (cmbOperator.SelectedIndex == 0)
            //{
            //    Result= 0;
            //}
            //else if(cmbOperator.SelectedIndex == 1)
            //{
            //    Result=num1+num2 ;
            //}
            //else if (cmbOperator.SelectedIndex == 2) 
            //{
            //    Result=num1-num2 ;
            //}
            //else if(cmbOperator.SelectedIndex == 3)
            //{
            //    Result=num1*num2 ;
            //}
            //else 
            //{
            //    Result =(double) num1/num2;
            //} 
            #endregion

            switch (cmbOperator.SelectedIndex)
            {
                case 0: Result = 0; break;
                case 1: Result = num1 + num2; break;
                case 2: Result = num1 - num2; break;
                case 3: Result = num1 * num2; break;
                default: Result = (double)num1 / num2; break;
            }
            lblResult.Text = "result:" + string.Format("{0:0.00}", Result);
        }
    }
}
