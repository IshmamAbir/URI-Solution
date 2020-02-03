using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameListForm
{
    public partial class Form1 : Form
    {
        List<person> personList = new List<person>();


        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            person aPerson=new person();
            aPerson.FirstName = firstNameTextBox.Text;
            aPerson.MiddleName = middleNameTextBox.Text;
            aPerson.LastName = lastNameTextBox.Text;

            personList.Add(aPerson);


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            foreach (person persons in personList)
            {
                showListBox.Items.Add(persons.GetFullName());

            }
            
        }
    }
}
