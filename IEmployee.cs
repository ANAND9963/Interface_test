using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IEmployee
    {
        double ComputePay(double overTimeRate);
        double ComputeBonus(int yearsWorked, string dept);
    }
}
