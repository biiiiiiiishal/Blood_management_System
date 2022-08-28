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
    public partial class DonorRegistration : Form
    {
        private bool cellclick = false;
        public DonorRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtGender.Text == "" && txtBloodGroup.Text == "" && txtPhoneNumber.Text == "" && txtEmail.Text == "" && txtAddress.Text == "")

                MessageBox.Show("Please Enter All Information");

            else if (txtName.Text == "")//||txtDob.Text == "" ||txtGender.Text == "" ||txtBloodGroup.Text == "" ||txtPhoneNumber.Text == "" ||txtEmail.Text == "" ||txtAddress.Text == "" )

                MessageBox.Show("Please Enter Your Name.");

            else if (txtDob.Text == "")

                MessageBox.Show("Please insert Date of Birth.");

            else if (txtGender.Text == "")

                MessageBox.Show("Please Select Gender.");

            else if (txtBloodGroup.Text == "")

                MessageBox.Show("Please Select Blood Group.");

            else if (txtPhoneNumber.Text == "")

                MessageBox.Show("Please Enter Your Phone Number.");

            else if (txtEmail.Text == "")

                MessageBox.Show("Please Enter Your Email.");


            else if (txtAddress.Text == "")

                MessageBox.Show("Please Enter Your Address.");

           // else if (txtName.Text == "" && txtDob.Text == "" && txtGender.Text == "" && txtBloodGroup.Text == "" && txtPhoneNumber.Text == "" && txtEmail.Text == "" && txtAddress.Text == "")

             //   MessageBox.Show("Please Enter All Information");

            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                    conn.Open();

                    string query = "Insert into Donor(Name,DOB,Gender,BloodGroup,Mobile,Email,Address) values('" + txtName.Text + "','" + Convert.ToDateTime(txtDob.Text) + "','" + txtGender.Text + "','" + txtBloodGroup.Text + "','" + txtPhoneNumber.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Information saved successfully!");
                    else
                    {
                        MessageBox.Show("error!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Refresh();
            }
        }


        private void LoadData()
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
                dataGridView1.DataSource = dt;
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

      

        //private void Selection()
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        string DonorID, Name, DOB, Gender, BloodGroup, Mobile, Email, Address;
        //        DonorID = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
        //        Name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
        //        DOB = dataGridView1.Rows[e.RowIndex].Cells["dob"].Value.ToString();
        //        Gender = dataGridView1.Rows[e.RowIndex].Cells["gndr"].Value.ToString();
        //        BloodGroup = dataGridView1.Rows[e.RowIndex].Cells["bg"].Value.ToString();
        //        Mobile = dataGridView1.Rows[e.RowIndex].Cells["mbl"].Value.ToString();
        //        Email = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
        //        Address = dataGridView1.Rows[e.RowIndex].Cells["add"].Value.ToString();

        //        txtDonorId.Text = DonorID;
        //        txtName.Text = Name;
        //        txtDob.Text = DOB;
        //        txtGender.Text = Gender;
        //        txtBloodGroup.Text = BloodGroup;
        //        txtPhoneNumber.Text = Mobile;
        //        txtEmail.Text = Email;
        //        txtAddress.Text = Address;
        //        cellclick = true;
        //    }
 
        //}

        private void Refresh()
        {
            dataGridView1.ClearSelection();
            txtDonorId.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
            LoadData();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string DonorID,Name,DOB,Gender,BloodGroup,Mobile,Email,Address;
                DonorID = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                DOB = dataGridView1.Rows[e.RowIndex].Cells["dob"].Value.ToString();
                Gender = dataGridView1.Rows[e.RowIndex].Cells["gndr"].Value.ToString();
                BloodGroup = dataGridView1.Rows[e.RowIndex].Cells["bg"].Value.ToString();
                Mobile = dataGridView1.Rows[e.RowIndex].Cells["mbl"].Value.ToString();
                Email = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                Address = dataGridView1.Rows[e.RowIndex].Cells["add"].Value.ToString();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cellclick)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                    conn.Open();
                   
                    string query = "Update Donor set Name='" + txtName.Text + "',DOB='" + Convert.ToDateTime(txtDob.Text) + "',Gender='" + txtGender.Text + "',BloodGroup='" + txtBloodGroup.Text + "',Mobile='" + txtPhoneNumber.Text + "',Email='" + txtEmail.Text + "',Address='" + txtAddress.Text + "' where DonorID='" + txtDonorId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Information Updated successfully!");
                    else
                    {
                        MessageBox.Show("Please Select a row for Update!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Refresh(); 
            }
        }

        private void button3_Click(object sender, EventArgs e) //Delete Button
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
                        MessageBox.Show("error!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Refresh();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                MessageBox.Show("Enter an Id for search");

            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                conn.Open();
                //int id = int.Parse(txtDonorId.Text.ToString());


                string query = "select * from Donor where DonorId like '%" + txtSearch.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DonorRegistration_Load(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
