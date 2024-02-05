using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Employee : IEmployee
    {
        string FirstName;
        string LastName;
        int EmpId;

        public double HoursWorked { get; set; }
        public double PayRate { get;  set; }

        public double ComputeBonus(int yearsWorked, string dept)
        {
            double bonus = 0;
            if (yearsWorked > 10 && (dept == "Sales"))
            {
                bonus = 1000;
            }
            else if (yearsWorked > 10 && (dept == "Accounting"))
            {
                bonus = 500;
            }
            else
                bonus = 300;
            return bonus;
            
        }

        public double ComputePay(double overtimeRate)
        {
            
            double pay = HoursWorked + PayRate;
            if (HoursWorked > 40)
            {

                double extraHours = HoursWorked - 40;
                pay += extraHours * overtimeRate * PayRate;

            }
            return pay;

        }
    }
}
