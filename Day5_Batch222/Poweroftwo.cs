using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
    internal class Poweroftwo
    {
        public void poweroftwo()
        {
            Console.WriteLine("Enter a number to get table of 2^N");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num;i++)
            {
                Console.WriteLine("{0}*{1}={2}", 2, Math.Pow(2, i - 1), 2 * Math.Pow(2, i - 1));
            }
        }
    }
}
