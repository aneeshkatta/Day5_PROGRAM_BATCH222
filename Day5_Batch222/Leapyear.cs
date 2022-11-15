using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
    internal class Leapyear
    {
        public void leapyear()
        {
            Console.WriteLine("Enter a year to check its leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine("yes {0} is leap year", year);
            }
            else
            {
                Console.WriteLine("yes {0} is not a leap year", year);
            }
        }
    }
}
