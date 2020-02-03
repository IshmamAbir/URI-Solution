using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labExam1
{
    public partial class Form1 : Form
    {
        public double calculateTotalAmount(int admissionFee, int tuitionFee)
        {
            double calculate;
            calculate = admissionFee + (tuitionFee*12);
            return calculate;
        }

        public Form1()
        {
            InitializeComponent();
        }
        int  admissionFee, monthlyFee;
        double totalCost, discount,annualCost;

        private void calculateButton_Click(object sender, EventArgs e)
        {

            string choose = classComboBox.Text;
            if (choose == "class 1")
            {
                admissionFee = Convert.ToInt32(10000);
                monthlyFee = Convert.ToInt32(500);
                totalCost=calculateTotalAmount(admissionFee, monthlyFee);
            }

            else if (choose == "class 2")
            {
                admissionFee = Convert.ToInt32(10000);
                monthlyFee = Convert.ToInt32(500);
                totalCost=calculateTotalAmount(admissionFee, monthlyFee);
            }

            else if (choose == "class 3")
            {
                admissionFee = Convert.ToInt32(10000);
                monthlyFee = Convert.ToInt32(1000);
                totalCost = calculateTotalAmount(admissionFee, monthlyFee);
            }

            else if (choose == "class 4")
            {
                admissionFee = Convert.ToInt32(10000);
                monthlyFee = Convert.ToInt32(1000);
                totalCost = calculateTotalAmount(admissionFee, monthlyFee);
            }

            if (choose == "class 5")
            {
                admissionFee = Convert.ToInt32(10000);
                monthlyFee = Convert.ToInt32(1000);
                totalCost = calculateTotalAmount(admissionFee, monthlyFee);
            }

            else if (choose == "class 6")
            {
                admissionFee = Convert.ToInt32(12000);
                monthlyFee = Convert.ToInt32(1500);
                totalCost = calculateTotalAmount(admissionFee, monthlyFee);

            }

            else if (choose == "class 7")
            {
                admissionFee = Convert.ToInt32(12000);
                monthlyFee = Convert.ToInt32(1500);
                totalCost = calculateTotalAmount(admissionFee, monthlyFee);
            }

            else if (choose == "class 8")
            {
                admissionFee = Convert.ToInt32(12000);
                monthlyFee = Convert.ToInt32(1500);
                totalCost = calculateTotalAmount(admissionFee, monthlyFee);
            }

            else if (choose == "class 9")
            {
                admissionFee = Convert.ToInt32(15000);
                monthlyFee = Convert.ToInt32(2000);
                totalCost = calculateTotalAmount(admissionFee, monthlyFee);
            }

            if (choose == "class 10")
            {
                admissionFee = Convert.ToInt32(15000);
                monthlyFee = Convert.ToInt32(2000);
                totalCost = calculateTotalAmount(admissionFee, monthlyFee);
            }

            else if (choose == "class 11")
            {
                admissionFee = Convert.ToInt32(15000);
                monthlyFee = Convert.ToInt32(2700);
                totalCost = calculateTotalAmount(admissionFee, monthlyFee);
            }

            else if (choose == "class 12")
            {
                admissionFee = Convert.ToInt32(15000);
                monthlyFee = Convert.ToInt32(2700);
                totalCost = calculateTotalAmount(admissionFee, monthlyFee);
            }




            if (discountCheckBox.Checked==true)
            {
                discount = (totalCost * 0.05);
            }
            
            if (discountCheckBox.Checked==false)
            {
                discount = Convert.ToInt32(0);
            }
            


            annualCost = (totalCost - discount);

            MessageBox.Show(annualCost.ToString(), "Annual Cost",MessageBoxButtons.OKCancel);
        }
    }
}
