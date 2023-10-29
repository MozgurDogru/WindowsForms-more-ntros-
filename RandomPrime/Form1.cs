using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPrime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbRandom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd= new Random();
            int number;

            ArrayList numbers = new ArrayList();
            ArrayList primes = new ArrayList();

            cmbPrime.Items.Clear();
            cmbRandom.Items.Clear();    
            for (int i = 0; i < 20; i++)
            {
                do
                {
                    number = rnd.Next(2, 100);
                } while (numbers.Contains(number.ToString().PadLeft(2, '0')));

                numbers.Add(number.ToString().PadLeft(2, '0'));

                if (IsPrime(number)) primes.Add(number.ToString().PadLeft(2, '0'));
            }

            numbers.Sort();

            cmbRandom.Items.AddRange(numbers.ToArray());

            primes.Sort();
            cmbPrime.Items.AddRange(primes.ToArray());



        }
        private static bool  IsPrime(int number)
        {
            bool k = true;
            for (int j = 2; j < number; j++)
            {
                if (number % j == 0) { k = false; break; }
            }

            return k;
        }


    }
}
