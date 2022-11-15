using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
    internal class Swapnum
    {
        public void swapnum()
        {
            Console.WriteLine("Enter a number A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping numbers");
            Console.WriteLine("A=" + A);
            Console.WriteLine("B=" + B);
            int temp;
            temp = A;
            A = B;
            B = temp;
            Console.WriteLine("After swapping numbers");
            Console.WriteLine("A=" + A);
            Console.WriteLine("B=" + B);

        }
    }
}
