using System;

namespace NUnitTesting
{
   public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to NUnit Testing Programs");
            Console.WriteLine("\n 1. Vending Machine \n" +
                               "\n 2. Days Of Week  \n " +
                               "\n 3. Temperature Conversion \n" +
                               "\n 4. Monthly Payment \n" +
                               "\n 5. Exit  ");
            Console.WriteLine("\n Choose Any Program \n");
            bool flag = true;
            while (flag)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        VendingMachine VM = new VendingMachine();
                        VM.Notes();
                        break;
                    case 2:
                        DaysOfWeek DOW = new DaysOfWeek();
                        DOW.GregorianCalender();
                        break;

                    case 3:
                        TemperatureConversion Temp = new TemperatureConversion();
                        Temp.Degrees();
                        break;
                    case 4:
                        MonthlyPayment.Payments(3,4,5);
                        break;

                    case 5:
                        flag= false;
                        break;

                    default:
                        Console.WriteLine("Enter Correct Number");
                        break;
                }
            }
            
            
        }
    }
}
