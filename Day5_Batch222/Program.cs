using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Batch222
{
     class program
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
                    Leapyear obj = new Leapyear();
                    obj.leapyear();
                    break;
                case 3:
                    Poweroftwo obj= Poweroftwo()
                    obj.poweroftwo();
                    break;
                case 4:
                    HarmonicNo obj = new HarmonicNo();
                    obj.harmonicno();
                    break;
                case 5:
                    PrimeFactor obj = new PrimeFactor();
                    obj.primefactor();
                    break;
                case 6:
                    QuotientRem obj = new QuotientRem();
                    obj.quotientrem();
                    break;
                case 7:
                    Swapnum obj = new Swapnum();
                    obj.swapnum();
                    break;
                case 8:
                    Evenodd obj = new Evenodd();
                    obj.evenodd();
                    break;
                case 9:
                    Vowelcons = new Vowelcons();
                    obj.vowelcons();
                    break;
                case 10:
                    Largest3Nos obj = new Largest3Nos();
                    obj.largest3Nos();
                default:
                    Console.WriteLine("Enter between 1-10 no.s only");
                    break;

            }
        }
    }
}
