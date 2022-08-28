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
    
    public partial class Inventory : Form
    {
        
        public Inventory()
        {
            InitializeComponent();
        }

        private void ShowInv_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                conn.Open();
                string query = "select BloodGroup,BloodUnits from Inventory";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewInv.DataSource = dt;
               //// dataGridViewInv.AutoGenerateColumns = false;

                dataGridViewInv.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddBloodUnits_Click(object sender, EventArgs e)
        {
            if (txtBloodGroup.Text == "" || txtBloodUnits.Text == "")
                MessageBox.Show("Please Select Blood Group & Blood Units");
            else
            {
                try
                {

                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                    conn.Open();

                    string query = "Update Inventory set BloodUnits=BloodUnits+ " + txtBloodUnits.Text + " where BloodGroup='" + txtBloodGroup.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Information Updated!");
                    else
                    {
                        MessageBox.Show("error!!!");
                    }

                    Inventory_Load(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Refresh();
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                conn.Open();
                string query = "select * from Inventory";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridViewInv.DataSource = dt;
                // dataGridViewInv.AutoGenerateColumns = false;

                dataGridViewInv.Refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
        private void txtBloodUnits_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveBloodUnits_Click(object sender, EventArgs e)
        {
            if (txtBloodGroup.Text == "" || txtBloodUnits.Text == "")
                MessageBox.Show("Please Select Blood Group & Blood Units");
            else
            {
                try
                {

                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                    conn.Open();

                    string query = "Update Inventory set BloodUnits=BloodUnits - " + txtBloodUnits.Text + " where BloodGroup='" + txtBloodGroup.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Information Updated!");
                    else
                    {
                        MessageBox.Show("error!!!");
                    }

                    Inventory_Load(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Refresh();
            }
        }

        private void dataGridViewInv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtBloodGroup.Text == "" || txtBloodUnits.Text == "")
                MessageBox.Show("Please insert Informations");
            else
            {
                try
                {

                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-827GKI0;Initial Catalog=BMS;Integrated Security=True");
                    conn.Open();

                    string query = "Update Inventory set BloodUnits=BloodUnits+ " + txtBloodUnits.Text + " where BloodGroup='" + txtBloodGroup.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Information Updated!");
                    else
                    {
                        MessageBox.Show("error!!!");
                    }

                    Inventory_Load(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Refresh();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

        private void Refresh()
        {
            dataGridViewInv.ClearSelection();
            txtBloodGroup.Text = "";
            txtBloodUnits.Text = "";
           




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridViewInv.Width, this.dataGridViewInv.Height);
            dataGridViewInv.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridViewInv.Width, this.dataGridViewInv.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
