using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lunchBillCalculatorForm
{
    public partial class Lunch : Form
    {
        private int totalBill, grossBill;
        public Lunch()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lunch_Load(object sender, EventArgs e)
        {

        }

        private void totalShowButton_Click(object sender, EventArgs e)
        {
            int rice=0, fish=0, meat=0;

            rice = (Convert.ToInt32(riceTextBox.Text))*20;
            fish = (Convert.ToInt32(fishTextBox.Text))*80;
            meat = (Convert.ToInt32(meatTextBox.Text))*100;

            riceTextBox.Clear();
            fishTextBox.Clear();
            meatTextBox.Clear();

            totalBill = rice + fish + meat;
            showGrossTextBox.Text = Convert.ToString(totalBill);



        }

        private void netBillShowButton_Click(object sender, EventArgs e)
        {
            int gross;
            double netBill,discount=0.00;

            gross = Convert.ToInt32(showGrossTextBox.Text);
            discount = gross*((Convert.ToDouble(discountTextBox.Text))/100);

            netBill = gross + (gross*0.05) - discount;


                MessageBox.Show("Total Bill is :" + netBill ,"Net Bill",MessageBoxButtons.OKCancel);
            


        }
    }
}
