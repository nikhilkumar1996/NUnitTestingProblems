using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class BinaryNo
    {
        public static void ToBinary(int decimalNo)
        {
            int count;
            
            List<int> binaryNumber = new List<int>();
            for (count = 0; decimalNo > 0; count++)
            {
                binaryNumber.Add(decimalNo % 2);
                decimalNo = decimalNo / 2;
            }
            
            Console.Write("Binary Representation is =\t");
            foreach(var data in binaryNumber)
            {
                Console.Write(data);
            }
        }
    }
    
}
