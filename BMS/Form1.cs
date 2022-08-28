using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtuname.Text =="admin" && txtpass.Text == "admin")
            {
                HomePage hp = new HomePage();
                hp.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Enter a valid Username or password. ", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnpassShow.Text == "Show")
            {
                btnpassShow.Text = "Hide";
                txtpass.PasswordChar = '\0';
            }
            else
            {
                btnpassShow.Text = "Show";
                txtpass.PasswordChar = '*';
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}