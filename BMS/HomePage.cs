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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void findDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchWithBloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bloodInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DonorRegistration Dreg = new DonorRegistration();
            Dreg.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindDonor fd = new FindDonor();
            fd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           SearchDonor SDono = new SearchDonor();
            SDono.Show();
            this.Hide();
        }
    }
}
