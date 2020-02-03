using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountWebApp
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            person aPerson=new person();
            aPerson.AccountNumber = accountNumberTextBox.Text;
            aPerson.CustomerName = customerNameTextBox.Text;

            accountNumberTextBox.Enabled = false;
            customerNameTextBox.Enabled = false;
            saveButton.Enabled = false;

            ViewState["accountVS"] = aPerson;
        }

        protected void depositButton_Click(object sender, EventArgs e)
        {
            person aPerson = (person) ViewState["accountVS"];
            string message = aPerson.Deposit(Convert.ToDouble(amountTextBox.Text));
            reportLabel.Text = message;
            ViewState["accountVS"] = aPerson;


        }

        protected void withdrawButton_Click(object sender, EventArgs e)
        {
            person aPerson = (person)ViewState["accountVS"];
            reportLabel.Text = aPerson.Withdraw(Convert.ToDouble(amountTextBox.Text));
            ViewState["accountVS"] = aPerson;
        }

        protected void reportButton_Click(object sender, EventArgs e)
        {
            person aPerson = (person) ViewState["accountVS"];
            reportLabel.Text = aPerson.Report();
        }
    }
}