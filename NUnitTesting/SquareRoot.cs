using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class SquareRoot
    {
        public static void Sqrt()
        {
            Console.WriteLine("Enter input for Square Roots:");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Approx Square Root:" + Math.Sqrt(input));
        }
    } 
    
}
