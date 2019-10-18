using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class SalaryCount
    {
        public string employeename;
        public double basicsalary;
        public double salary;
        public double houserent;
        public double medicalallowance;
        public double totalsalary()
        {
            houserent = (basicsalary * houserent) / 100;
            medicalallowance = (basicsalary * medicalallowance) / 100;
            salary = (basicsalary +houserent+medicalallowance );
            return salary;
        }
        public string showmesalary()
        {
            var msg = employeename +" "+ "your salary is:" + totalsalary() ;
            return msg;
        }
      
    }
}
