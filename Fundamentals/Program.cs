using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Loop that prints all values from 1 - 255
            for (int i = 1; i < 256; i++)
            {
               // Console.WriteLine(i);
            }
            //DivisibleBy();
            //FizzBuzz();
            FizzBazzII();

           

        }

        //Create a new loop that prints all values from 1 - 100 that are divisible by 3 or 5, but not both
        static void DivisibleBy()
        {
            int five = 5;
            int three = 3;
            for (int i = 1; i < 101; i++)
            {
                if (i % 15 != 0 && (i % five == 0 || i % three == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }


        //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
       
        static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("{0}- FizzBuzz", i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("{0}- Buzz", i);
                }
                else if( i % 3 == 0)
                {
                    Console.WriteLine("{0} -Fizz", i);
                }
            }
        }
        //(Optional)If you used modulus in the last step, try doing the same without using it.Vice - versa for those who didn't! 
        static bool IsMultiple(int number, int multipleNumber) // 3, 15 => true 
        {
            for (int i = 1; i <= multipleNumber/2; i++)
            {
                if( i * number == multipleNumber)
                {
                    return true;
                }
            }
            return false;
        }

        static void FizzBazzII()
        {
            for (int i = 0; i < 101; i++)
            {
                if (IsMultiple(15, i))
                {
                    Console.WriteLine("{0} FizzBazz", i);
                }
                else if (IsMultiple(3, i))
              
                {
                    Console.WriteLine("{0} Fizz", i);
                }
                else if (IsMultiple(5, i))
                {
                    Console.WriteLine("{0} Bazz", i);
                }
            }
        }


        //(Optional) Generate 10 random values and output the respective word, in relation to step three, for the generated values

    }
}
