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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        int idd;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            // idd= Form2.id;
            // MessageBox.Show(idd.ToString());
        }
        public string ProfileImage;
        public string Gender;
        public string Department;

        Form2 up = new Form2();

        public static string connectionString = @"Data Source=DESKTOP-4R67M0G\SQLEXPRESS;Initial Catalog=EmpPayrollSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = new SqlConnection(connectionString);
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void txtName_Enter(object sender, EventArgs e)
        {
           
            if (txtName.Text == "Your Name ....")
            {
                txtName.Text = "";

                txtName.ForeColor = Color.Black;
            }
        }

        public void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Your Name ....";
                txtName.ForeColor = Color.Silver;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ProfileImage = "Pic1";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ProfileImage = "Pic2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ProfileImage = "Pic3";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ProfileImage = "Pic4";
        }

        public void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        public void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Department = "HR";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Department = "Sales";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Department = "Finance";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Department = "Engineer";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Department = "Other";
        }

        private void trcSalary_Scroll(object sender, EventArgs e)
        {
            SalDisp.Text = trcSalary.Value.ToString();
        }

        public void Clear()
        {
            txtName.Clear();
            txtNote.Clear();
            StartDate.Text = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            Pic1.Checked = false;
            Pic2.Checked = false;
            Pic3.Checked = false;
            Pic4.Checked = false;
            Male.Checked = false;
            Female.Checked = false;
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Clear();

        }

        public void Submit1_Click(object sender, EventArgs e)
        {
            if (!Pic1.Checked && !Pic2.Checked && !Pic3.Checked && !Pic4.Checked)
            {
                MessageBox.Show("Please select Profile Image ", "Error");
                return;

            }
            if (!Male.Checked && !Female.Checked)
            {
                MessageBox.Show("Please select gender ", "Error");
                return;

            }
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Employee]
           ([Name]
           ,[ProfileIamge]
           ,[Gender]
           ,[Department]
           ,[Salary]
           ,[StartDate]
           ,[Notes])
     VALUES('" + txtName.Text + "','" + ProfileImage + "','" + Gender + "','" + Department + "','" + SalDisp.Text + "','" + StartDate.Text + "','" + txtNote.Text + "')", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Employee Registration successful");

            Clear();
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Reset1_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Clear();
            Form2 form2 = new Form2();
            
            form2.Show();
            

        }

        public void txtName_TextChanged(object sender, EventArgs e)
        {

        }
       

        public static string name;
        private void Update_Click(object sender, EventArgs e)
        {
            idd = Form2.id;
           // Name = Form2.Name1;
            //string txtName = name;
           // MessageBox.Show(idd.ToString());

            connection.Open();
           // txtName.Text = txtName.Text.Replace("System.Windows.Forms.TextBox, Text: ", string.Empty);
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Employee] set [Name] ='" + txtName.Text + "',[ProfileIamge]='" + ProfileImage + "',[Gender]='" + Gender + "',[Department]='" + Department + "',[Salary]='" + SalDisp.Text + "',[StartDate]='" + StartDate.Text + "',[Notes]='" + txtNote.Text + "' where ID='" + idd + "'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Update successful");
            this.Close();
            up.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gender = Form2.Gender;
            //MessageBox.Show(Gender);
            Department = Form2.Department;
            ProfileImage = Form2.ProfileImage;
            if (Gender == "Male")
            {

                Male.Checked = true;
            }
            if (Gender == "Female")
            {
                Female.Checked = true;
            }
            if (Department == "HR")
            {
                checkBox1.Checked = true;
            }
            if (Department == "Sales")
            {
                checkBox2.Checked = true;
            }
            if (Department == "Finance")
            {
                checkBox3.Checked = true;
            }
            if (Department == "Engineer")
            {
                checkBox4.Checked = true;
            }
            if (Department == "Other")
            {
                checkBox5.Checked = true;
            }
            if (ProfileImage == "Pic1")
            {
                Pic1.Checked = true;
            }
            if (ProfileImage == "Pic2")
            {
                Pic2.Checked = true;
            } 
            if (ProfileImage == "Pic3")
            {
                Pic3.Checked = true;
            } 
            if (ProfileImage == "Pic4")
            {
                Pic4.Checked = true;
            }
        }
    }
}
