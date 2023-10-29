using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        Label[] labels;
        Random rnd;
        int[] luckyNumbers;
        int counter = 0, period = 10, order = 0;

        private void btnTry_Click(object sender, EventArgs e)
        {
            LoadNumbers();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter++ % period == 0)
            {
                if (order < labels.Length)
                {
                    lbxNumbers.Items.Add(luckyNumbers[order].ToString().PadLeft(2, '0')); labels[order].Text = luckyNumbers[order].ToString().PadLeft(2, '0');
                }
                order++;
            }
            for (int i = order; i < labels.Length; i++)
            {
                labels[i].Text = rnd.Next(1, 50).ToString().PadLeft(2, '0');
            }
            if (order > labels.Length)
            {
                for (int i = 0; i < labels.Length; i++)
                {
                    labels[i].Visible = labels[i].Visible;
                }
            }
            if (order == labels.Length + 3)
            {
                Array.Sort(luckyNumbers);
                for (int i = 0; i < labels.Length; i++)
                {
                    labels[i].Visible = true;
                    labels[i].Text = luckyNumbers[i].ToString().PadLeft(2, '0');
                }
            }
        }

        private void LoadNumbers()
        {
            luckyNumbers = new int[6];
            int num;
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                do
                {
                    num = rnd.Next(1, 50);
                } while (luckyNumbers.Contains(num));

                luckyNumbers[i] = num;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            labels = new Label[] { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6 };
        }
    }
}
