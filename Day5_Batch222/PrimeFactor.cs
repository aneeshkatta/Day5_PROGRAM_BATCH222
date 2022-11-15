using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
    internal class PrimeFactor
    {
        public void primefactor()
        {
            Console.WriteLine("Enter a number to get prime factors with Logic -> Traverse till i*i <= N instead of i <= N");
            int N = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i*i<=N;i++)
            {
                if (N % i ==0)
                {
                    Console.WriteLine("{0} is a factor of {1}", i, N);
                }
            }
        }
    }
}
