using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class DaysOfWeek
    {
        public void GregorianCalender()
        {
            Console.WriteLine("Enter the date(1-30)");
            int day = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the month (1-12)");
            int month = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the year(yyyy)");
            int year = Convert.ToInt16(Console.ReadLine());
           
            DayCalculate(day, month, year);
        }



            public static void DayCalculate(int d, int m, int y)
            {
                
                List<string> day = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                
                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + 31 * m0 / 12) % 7;
                
                Console.WriteLine("Day is :" + day[d0]);
            }
    }
}


