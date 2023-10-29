using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsıntro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDisplay.ForeColor= Color.Black;
            this.Text = "Title Changed!";
            lblResult.ForeColor = Color.Orange;
            this.BackColor = Color.SeaGreen;

            for (int i = 0; i <= 100; i++)
            {
                cmbNumbers.Items.Add(i.ToString().PadLeft(3,'0'));
            }
            //lbxStudent.Items.Add("Mehmet");
            //lbxStudent.Items.Add("Sena");
            //lbxStudent.Items.Add("Gözde");
            //lbxStudent.Items.Add("Atıl");
            //lbxStudent.Items.Add("Kerim");
            ////lbxStudent.Items.Add("özgür");
            //String[] students = new String[] { "Mehmet", "Sena", "Gözde", "Atıl", "Kerim", "Özgür" };
            //lbxStudent.Items.AddRange(students);

            lbxStudent.Items.AddRange(new String[] { "Mehmet", "Sena", "Gözde", "Atıl", "Kerim", "Özgür" });

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba dünya!");
            lblResult.Text= txtInput.Text;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //if (rbtnMale.Checked)
            //{
            //    lblResult.Text = "Male";
            //}
            //else
            //{
            //    lblResult.Text = "Female";
            //}
            lblResult.Text= string.Empty;   
            if (chbBook.Checked)
            {
                lblResult.Text += "Book ";
            }
            if (chbCinema.Checked)
            {
                lblResult.Text += "Cinema ";
            }
            if (chbMusic.Checked)
            {
                lblResult.Text += "Music ";
            }
        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMale.Checked)
            {
                lblResult.Text = "Male Selected.";
            }
            else
            {
                lblResult.Text = "Female Selected.";
            }

            {
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = txtInput.Text; 
        }

        private void cmbNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult.Text = cmbNumbers.SelectedItem.ToString();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnfener_Click(object sender, EventArgs e)
        {
            btnfener.BackColor= Color.Blue;
            btnfener.ForeColor = Color.Yellow;
            btnfener.Text="Lacivert";

            this.Refresh(); 
            System.Threading.Thread.Sleep(2000);
            btnfener.BackColor= Color.Yellow;
            btnfener.ForeColor = Color.Blue;
            btnfener.Text= "Şampiyon";

            this.Refresh();
            System.Threading.Thread.Sleep(2000);
            btnfener.BackColor= Color.Blue;
            btnfener.ForeColor = Color.Yellow;
            btnfener.Text = "Fener";

            this.Refresh();
            System.Threading.Thread.Sleep(2000);
            btnfener.BackColor = Color.Yellow;
            btnfener.ForeColor = Color.Blue;
            btnfener.Text = "Sarı";
        }
    } }
