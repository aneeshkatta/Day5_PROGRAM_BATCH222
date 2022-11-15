using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
    internal class Evenodd
    {
        public void evenodd()
        {
            Console.WriteLine("Enter a number to check its even or odd");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("no. is a even");
            }
            else
            {
                Console.WriteLine("no. is a Odd");
            }
        }
    }
}
