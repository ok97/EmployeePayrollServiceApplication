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
            ctvalue.Text = count.ToString();
        }

        private void value_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Submit1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();

            form1.Show();
        }
    }
}
