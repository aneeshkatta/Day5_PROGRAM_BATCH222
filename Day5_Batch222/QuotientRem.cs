using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
    internal class QuotientRem
    {
        public void quotientrem()
        {
            Console.WriteLine("Enter dividend value to get quotient and remainder");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor value to get quotient and remainder");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int quotient = Convert.ToInt32((num / num1));
            int remainder = (num % num1);
            Console.WriteLine("Quotient is {0}", quotient);
            Console.WriteLine("Remainder is {0}", remainder);
        }
    }
}
