using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;

namespace CURD_in_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3C20DQN\\SQLEXPRESS;Initial Catalog=ProductInformation;Integrated Security=True;Encrypt=False");


        private void Insertbtn_Click(object sender, EventArgs e)
        {

            if (IDtxt.Text != "" && int.Parse(IDtxt.Text) != 0)
            {
                con.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO ProductInfo_Tab (Product_ID, Item_Name, Design, Color, InserDate) VALUES ('" + int.Parse(IDtxt.Text) + "','" + Nametxt.Text + "','" + Designtxt.Text + "','" + Colortxt.Text + "',getdate())", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfullly Inseted.....", "Completed...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                    BindData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Key Already Exist...", "Duplicate Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                // MessageBox.Show("Product_ID Not Valid....." ,"Warning");
                MessageBox.Show("Product_ID Not Valid.....", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }



        }


        void BindData()
        {
            SqlCommand command = new SqlCommand("Select * From ProductInfo_Tab", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if(IDtxt.Text != "" && int.Parse(IDtxt.Text) != 0 )
            {

                con.Open();
               
                    SqlCommand command = new SqlCommand("update ProductInfo_Tab SET Item_Name ='" + Nametxt.Text + "',Design ='" + Designtxt.Text + "',Color ='" + Colortxt.Text + "', UpdateDate = getdate() where Product_ID='" + int.Parse(IDtxt.Text) + "'", con);

                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfullly Updated.....", "Completed...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindData();
            
               
            }
            else
            {
                MessageBox.Show("Enter Valid Details.... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text != "")
            {
                if (MessageBox.Show("Are you Sure to Delete ? ", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("DELETE ProductInfo_Tab where Product_ID = '" + int.Parse(IDtxt.Text) + "' ", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Deleted...", "Completed...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindData();
                }
                else
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter Product_ID....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text != "")
            {
                SqlCommand command = new SqlCommand("Select * From ProductInfo_Tab where Product_ID = '" + int.Parse(IDtxt.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
               
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    // Fill the fields with the retrieved data
                    Nametxt.Text = reader["Item_Name"].ToString();
                    Designtxt.Text = reader["Design"].ToString();
                    Colortxt.Text = reader["Color"].ToString();
                }
                else
                {
                    MessageBox.Show("No record found with the given ID.","No Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Enter Product ID.... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {

            IDtxt.Clear();
            Nametxt.Clear();
            Designtxt.Clear();
            Colortxt.SelectedIndex = -1;


            /*
            foreach (Control control in this.Controls)
            {
                
                if (control is TextBox textBox)
                {
                   
                    textBox.Clear();
                }
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; 
                }
            }

           
            
            */
        }
    }
}
