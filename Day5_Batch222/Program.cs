using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
     class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter program number 1.Flipcoin \n\r 2.Leap year \n\r 3.Power of 2\n\r 4.Harmonic Number\n\r 5.Prime Factors \n\r6.Compute Quotient and Remainder\n\r7.Swap Two Numbers\n\r 8.Check Whether a Number is Even or Odd\n\r9.to Check Whether an Alphabet is Vowel or Consonant\n\r10.to Find the Largest Among Three Numbers");
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    Flipcoin obj = new Flipcoin();
                    obj.flipcoin();
                    break;
                case 2:
                    Leapyear obj1 = new Leapyear();
                    obj1.leapyear();
                    break;
                case 3:
                    Poweroftwo obj2 = new Poweroftwo();
                    obj2.poweroftwo();
                    break;
                case 4:
                    HarmonicNo obj3 = new HarmonicNo();
                    obj3.harmonicno();
                    break;
                case 5:
                    PrimeFactor obj4 = new PrimeFactor();
                    obj4.primefactor();
                    break;
                case 6:
                    QuotientRem obj5 = new QuotientRem();
                    obj5.quotientrem();
                    break;
                case 7:
                    Swapnum obj6 = new Swapnum();
                    obj6.swapnum();
                    break;
                case 8:
                    Evenodd obj7 = new Evenodd();
                    obj7.evenodd();
                    break;
                case 9:
                    Vowelcons obj8 = new Vowelcons();
                    obj8.vowelcons();
                    break;
                case 10:
                    Largest3Nos obj9 = new Largest3Nos();
                    obj9.largest3Nos();
                    break;
                default:
                    Console.WriteLine("Enter between 1-10 no.s only");
                    break;

            }
        }
    }
}
