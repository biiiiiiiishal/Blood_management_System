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
    public partial class SearchDonor : Form
    {
        private bool cellclick = false;
        public SearchDonor()
        {
            InitializeComponent();
        }

        private void SearchDonor_Load(object sender, EventArgs e)
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
               // dataGridViewSearch.AutoGenerateColumns = false;

               // dataGridViewSearch.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string DonorID, Name, DOB, Gender, BloodGroup, Mobile, Email, Address;
                DonorID = dataGridViewSearch.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Name = dataGridViewSearch.Rows[e.RowIndex].Cells["name"].Value.ToString();
                DOB = dataGridViewSearch.Rows[e.RowIndex].Cells["dob"].Value.ToString();
                Gender = dataGridViewSearch.Rows[e.RowIndex].Cells["gndr"].Value.ToString();
                BloodGroup = dataGridViewSearch.Rows[e.RowIndex].Cells["bg"].Value.ToString();
                Mobile = dataGridViewSearch.Rows[e.RowIndex].Cells["mbl"].Value.ToString();
                Email = dataGridViewSearch.Rows[e.RowIndex].Cells["email"].Value.ToString();
                Address = dataGridViewSearch.Rows[e.RowIndex].Cells["add"].Value.ToString();

                txtDonorId.Text = DonorID;
                txtName.Text = Name;
                txtDob.Text = DOB;
                txtGender.Text = Gender;
                txtBloodGroup.Text = BloodGroup;
                txtPhoneNumber.Text = Mobile;
                txtEmail.Text = Email;
                txtAddress.Text = Address;

                cellclick = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDISearch.Text == "")
                MessageBox.Show("Enter an Id For Search");

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                conn.Open();
                //int id = int.Parse(txtDonorId.Text.ToString());


                string query = "select * from Donor where DonorId like '" + txtDISearch.Text + "'";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cellclick)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                    conn.Open();

                    string query = "Delete Donor where DonorID='" + txtDonorId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Information Deleted successfully!");
                    else
                    {
                        MessageBox.Show("Please Select a row for Delete!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Refresh();
            }
        }
        private void Refresh()
        {
            dataGridViewSearch.ClearSelection();
            txtDonorId.Text = "";
            txtName.Text = "";
            txtDob.Text = "";
            txtGender.Text = "";
            txtBloodGroup.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtDISearch.Text = "";
            LoadData();

        }

        private void LoadData() //work as Show button
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDonorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //Show Table
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void txtDISearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            Refresh();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridViewSearch.Width, this.dataGridViewSearch.Height);
            dataGridViewSearch.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridViewSearch.Width, this.dataGridViewSearch.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
