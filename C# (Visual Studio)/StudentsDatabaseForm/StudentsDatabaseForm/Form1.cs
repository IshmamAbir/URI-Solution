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

namespace StudentsDatabaseForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.Age = Convert.ToInt32(ageTextBox.Text);
            aStudent.Address = addressTextBox.Text;
            aStudent.Department = departmentTextBox.Text;


            string constring = @"Data Source=DESKTOP-NUPBCTF;Initial Catalog=StudentDB;Integrated Security=True";
             SqlConnection connection=new SqlConnection(constring);

            string query= "INSERT INTO Students VALUES('" + aStudent.RegNo + "','" + aStudent.Name + "'," +
                           aStudent.Age + ",'" + aStudent.Address + "','" + aStudent.Department + "')";

            SqlCommand command=new SqlCommand(query,connection);

            connection.Open();

            int rowAffect = command.ExecuteNonQuery();

            connection.Close();

            regNoTextBox.Clear();
            nameTextBox.Clear();
            ageTextBox.Clear();
            departmentTextBox.Clear();
            addressTextBox.Clear();

            if (rowAffect>0)
            {
                outputLabel.Text = "Save Successful";
            }
            else
            {
                outputLabel.Text="Saving Failed";
            }
        }
    }
}
