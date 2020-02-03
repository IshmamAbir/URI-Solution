using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal_InfoForm
{

    
    public partial class Form1 : Form
    {
        private string firstName, father, mother, address, lastName;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            firstNameTextBox.Clear();

            lastName = lastNameTextBox.Text;
            lastNameTextBox.Clear();

            father = fatherTextBox.Text;
            fatherTextBox.Clear();

            mother = motherTextBox.Text;
            motherTextBox.Clear();

            address = addressTextBox.Text;
            addressTextBox.Clear();
        }

        private void allShowButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fatherTextBox.Text = father;
            motherTextBox.Text = mother;
            addressTextBox.Text = address;

        }
    }
}
