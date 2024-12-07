using System.Data;
using System.Data.SqlClient;

namespace CURD_Practice
{
    public partial class CURD : Form
    {
        public CURD()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-3C20DQN\\SQLEXPRESS;Initial Catalog=StudentInfo;Integrated Security=True;Encrypt=False");
        private void insertbtn_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlCommand Command = new SqlCommand("INSERT INTO StudentInfo_Tab(ID,Name,SirName,Age,InsertDate) VALUES ('" + int.Parse(IDtxt.Text) + "', '" + Nametxt.Text + "', '" + Snametxt.Text + "', '" + Agetxt.Text + "', getdate())", Con);
            try
            {
                Command.ExecuteNonQuery();

                MessageBox.Show("Inserted Successfully....");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            BindData();



        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("Select * from StudentInfo_Tab", Con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }


        private void CURD_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void UPDATEbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand command = new SqlCommand("update StudentInfo_Tab SET Name = '" + Nametxt.Text + "', SirName = '" + Snametxt.Text + "', Age = '" + Agetxt.Text + "', UpdateDate = getdate() where ID = '" + int.Parse(IDtxt.Text) + "' ", Con);

            command.ExecuteNonQuery();
            MessageBox.Show("Updated....");
            Con.Close();
            BindData();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand command = new SqlCommand(" DELETE StudentInfo_Tab where ID = '" + int.Parse(IDtxt.Text) + "'", Con);
            command.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Deleted......");
            BindData();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand command = new SqlCommand("SELECT * from StudentInfo_Tab where ID = '"+int.Parse(IDtxt.Text)+"'",Con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
           dataGridView1.DataSource = dt;


            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                Nametxt.Text = reader["Name"].ToString();
                Snametxt.Text = reader["SirName"].ToString();
                Agetxt.Text = reader["Age"].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found");
            }



            Con.Close();
            MessageBox.Show("Showing Detail.....");
            BindData();
        }
    }
}
