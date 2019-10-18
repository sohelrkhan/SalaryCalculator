using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }
        SalaryCount _salaryCount = new SalaryCount();

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            string msg;
            _salaryCount.employeename = employeeNameTextBox.Text;
            _salaryCount.basicsalary = Convert.ToDouble(basicAmountTextBox.Text);
            _salaryCount.houserent = Convert.ToDouble(homeRentTextBox.Text);
            _salaryCount.medicalallowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            msg = _salaryCount.showmesalary();
            MessageBox.Show(msg);

        }
    }
}
