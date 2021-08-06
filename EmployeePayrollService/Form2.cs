using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayrollService
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public static int id;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }
        public static string connectionString = @"Data Source=DESKTOP-4R67M0G\SQLEXPRESS;Initial Catalog=EmpPayrollSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(connectionString);
        private void Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // New page
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM [dbo].[Employee]", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            Details.DataSource = dtbl;
            connection.Close();

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*)  from [dbo].[Employee]", connection);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            connection.Close();
            ctvalue.Text = count.ToString(); DataReload();
        }

        private void value_Click(object sender, EventArgs e)
        {


        }
        public void DataReload()
        {
            // New page
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM [dbo].[Employee]", connection);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);
            Details.DataSource = dtbl;
            connection.Close();

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*)  from [dbo].[Employee]", connection);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            connection.Close();
            ctvalue.Text = count.ToString();
        }
        private void Submit1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();          
            form1.Show();
           
            
        }
        public int EmployeID;
        public void Details_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //Form1 update = new Form1();
            //update.txtName.Text = Details.Rows[e.RowIndex].Cells[0].Value.ToString();
            //update.ProfileImage = Details.Rows[e.RowIndex].Cells[1].Value.ToString();
            //update.Gender = Details.Rows[e.RowIndex].Cells[2].Value.ToString();
            //update.Department = Details.Rows[e.RowIndex].Cells[3].Value.ToString();
            //update.SalDisp.Text = Details.Rows[e.RowIndex].Cells[4].Value.ToString();
            //update.StartDate.Text = Details.Rows[e.RowIndex].Cells[5].Value.ToString();
            //update.txtNote.Text = Details.Rows[e.RowIndex].Cells[6].Value.ToString();
            //EmployeID = Convert.ToInt32(Details.Rows[e.RowIndex].Cells[7].Value.ToString());

            //update.ShowDialog();
            //MessageBox.Show(EmployeID.ToString());

        }
        public static string Name1;
        public static string Gender;
        public static string Department;
        public static string ProfileImage;

        public void Details_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form1 update = new Form1();
            update.txtName.Text = Details.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            //update.txtName.Text = update.txtName.Text.Replace("System.Windows.Forms.TextBox, Text: ", string.Empty);
             // Name1 = Details.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            ProfileImage = Details.Rows[e.RowIndex].Cells["ProfileIamge"].FormattedValue.ToString();
            Gender = Details.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
            Department = Details.Rows[e.RowIndex].Cells["Department"].FormattedValue.ToString();
            update.SalDisp.Text = Details.Rows[e.RowIndex].Cells["Salary"].FormattedValue.ToString();
            update.StartDate.Text = Details.Rows[e.RowIndex].Cells["StartDate"].FormattedValue.ToString();
            update.txtNote.Text = Details.Rows[e.RowIndex].Cells["Notes"].FormattedValue.ToString();
            id = Convert.ToInt32(Details.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());    
            
            update.Show();
           // (this.Owner as Form1).Submit1.Enabled = true;
        }

        private void Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             id = Convert.ToInt32(Details.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete ?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                
                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from [dbo].[Employee] where ID ='" + id + "' ", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Delete successful");
                DataReload();


            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            DataReload();
        }
    }
}
