using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BMS
{
    public partial class FindDonor : Form
    {
        public FindDonor()
        {
            InitializeComponent();
        }

        private void FindDonor_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                conn.Open();
                string query = "select * from Donor";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewSearch.DataSource = dt;
                dataGridViewSearch.AutoGenerateColumns = false;

                dataGridViewSearch.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchLocation_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtBloodGroup1.Text == "")
                MessageBox.Show("Please Enter Address & Blood Group");

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                conn.Open();
                //int id = int.Parse(txtDonorId.Text.ToString());


                string query = "select * from Donor where Address like '" + txtAddress.Text + "' AND BloodGroup like '" + txtBloodGroup1.Text + "'" ;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewSearch.DataSource = dt;
            
                dataGridViewSearch.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchBloodGroup_Click(object sender, EventArgs e)
        {
            if (txtBloodGroup.Text == "")
                MessageBox.Show("Please Enter Blood Group");

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                conn.Open();
                //int id = int.Parse(txtDonorId.Text.ToString());


                string query = "select * from Donor where BloodGroup like '" + txtBloodGroup.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewSearch.DataSource = dt;
                dataGridViewSearch.AutoGenerateColumns = false;

                dataGridViewSearch.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Refresh()
        {
            dataGridViewSearch.ClearSelection();
            txtAddress.Text = "";
            txtBloodGroup.Text = "";
            txtBloodGroup1.Text = "";
          
     


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                conn.Open();
                string query = "select * from Donor";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewSearch.DataSource = dt;
                dataGridViewSearch.AutoGenerateColumns = false;

                dataGridViewSearch.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridViewSearch.Width, this.dataGridViewSearch.Height);
            dataGridViewSearch.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridViewSearch.Width, this.dataGridViewSearch.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
