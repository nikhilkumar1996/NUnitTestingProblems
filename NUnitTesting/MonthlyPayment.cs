using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class MonthlyPayment
    {
        public static void Payments(int argument1, int argument2, int argument3)
        {

            double principalLoan = Convert.ToDouble(argument1);
            double year = Convert.ToDouble(argument2);
            double n = 12 * year;
            double r = principalLoan / (12 * 100);
            double percentInterest = Convert.ToDouble(argument3);
            double payment = (principalLoan * r) / 1 - Math.Pow(1 + r, -n);
            Console.WriteLine("Payment=" + payment);
        }
    }
}
