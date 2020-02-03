using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInfoWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
           

            Student aStudent=new Student();
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.Age = Convert.ToInt32(ageTextBox.Text);
            aStudent.Address = addressTextBox.Text;
            aStudent.Department = departmentTextBox.Text;

            string conString = @"Data Source=DESKTOP-NUPBCTF;Initial Catalog=StudentDB;Integrated Security=True";
           SqlConnection connection= new SqlConnection(conString);

            string query = "INSERT INTO Students VALUES('" + aStudent.RegNo + "','" + aStudent.Name + "'," +
                           aStudent.Age + ",'" + aStudent.Address + "','" + aStudent.Department + "')";

            SqlCommand command=new SqlCommand(query,connection);

            connection.Open();

            int rowAffect=command.ExecuteNonQuery();

            
            connection.Close();

           


            if (rowAffect>0)
            {
                outputLabel.Text = "Save Successfull";
            }
            else
            {
                outputLabel.Text = "Save Failed";
            }

            regNoTextBox.Text = "";
            nameTextBox.Text = "";
            ageTextBox.Text = Convert.ToString("");
            addressTextBox.Text = "";
            departmentTextBox.Text = "";
        }
    }
}