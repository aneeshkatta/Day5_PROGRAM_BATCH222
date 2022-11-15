using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
    internal class Largest3Nos
    {
        public void largest3Nos()
        {
            Console.WriteLine("Enter a number1 to get largest of three numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number2 to get largest of three numbers");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number3 to get largest of three numbers");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("num1 is Largest Number");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is Largest Number");
            }
            else
            {
                Console.WriteLine("num3 is Largest Number");
            }
        }
    }
}
