using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
    internal class HarmonicNo
    {
        public void harmonicno()
        {
            Console.WriteLine("Enter a  number N to get harmonic series sum in the series 1/1 + 1/2 + ... + 1/N ");
            int num= Convert.ToInt32(Console.ReadLine()); 
            double b = 0.00;
            for(double i=1;i<=num;i++)
            {
                Console.WriteLine("1/{0}+", i);
                b = 1 + (1 / i);
            }
            Console.WriteLine("harmonic series sum is :" + b);

        }
    }
}
