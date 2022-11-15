using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
    internal class Flipcoin
    {
        public void flipcoin()
        {
            Console.WriteLine("Enter number of times to toss ");
            double num = Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            double headcount = 0.0;
            double tailcount = 0.0;
            for(int i=1;i<num;i++)
            {
                double coinflipresult = random.NextDouble();
                if(coinflipresult<0.5)
                {
                    Console.WriteLine("Tails won the game");
                    tailcount++;
                }
                else
                {
                    Console.WriteLine("Heads won the game");
                    headcount++;
                }
            }
            Console.WriteLine("Heads won by {0}%", (headcount / num));
            Console.WriteLine("Tails won by {0}%", (tailcount / num));
        }
    }
}
