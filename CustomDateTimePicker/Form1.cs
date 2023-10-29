using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtRezervation_ValueChanged(object sender, EventArgs e)
        {
            //lblRezervation.Text= dtRezervation.Value.ToString();
            lblRezervation.Text = dtRezervation.Value.ToShortDateString();
            // lblRezervation.Text = dtRezervation.Value.ToShortTimeString();
            // lblRezervation.Text = dtRezervation.Value.ToLocalTime().ToString();
            //  lblRezervation.Text = dtRezervation.Value.ToLongDateString().ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMonth.Items.Clear();
            cmbDay.Items.Clear();

            cmbMonth.Text = string.Empty;
            //cmbMonth.Text = "";
            //cmbMonth.Text = null;
            cmbDay.Text = string.Empty;
            LoadMonths();
        }

        private void LoadMonths()
        {
            int limit = 12;

            if (cmbYear.SelectedItem.ToString() == DateTime.Now.Year.ToString())
            {
                limit = DateTime.Now.Month;
            }
            for (int i = 1; i <= limit; i++)
            {
                cmbMonth.Items.Add(i);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDay.Items.Clear();
            cmbDay.Text = string.Empty;
            LoadDays();
        }

        private void LoadDays()
        {
            int limit = 31;

            switch ((int)cmbMonth.SelectedItem)
            {
                case 2:
                    if ((int)cmbYear.SelectedItem % 4 == 0)
                    {
                        limit = 29;
                    }
                    else
                    {
                        limit = 28;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11: limit = 30; break;
                default: limit = 31; break;
            }
            if (cmbYear.SelectedItem.ToString() == DateTime.Now.Year.ToString() && cmbMonth.SelectedItem.ToString() == DateTime.Now.Month.ToString())
            {
                limit = DateTime.Now.Day;
            }

            for (int i = 1; i <= limit; i++)
            {
                cmbDay.Items.Add(i);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelected.Text = cmbDay.Text + "." + cmbMonth.Text.PadLeft(2,'0') + "." + cmbYear.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadYears();
        }

        private void LoadYears()
        {
            cmbDay.Items.Clear();
            cmbMonth.Items.Clear();

            for (int i = DateTime.Now.Year; i >= 1950; i--)
            {
                cmbYear.Items.Add(i);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
