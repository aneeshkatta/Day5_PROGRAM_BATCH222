using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
    internal class Vowelcons
    {
        public void vowelcons()
        {
            Console.WriteLine("Enter an Alphabet(A-Z or a-z) to check its a Vowel or Consonent");
            char input = Convert.ToChar(Console.ReadLine().ToLower());
            switch (input)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is Consonent");
                    break;
            }
        }
    }
}
