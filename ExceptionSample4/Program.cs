using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSample2
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            bool ok = false;
            while (!ok)
            {
                Console.WriteLine("Enter Numerator");
                int numerator = int.Parse(Console.ReadLine());//8
                Console.WriteLine("Enter Denominator");
                int denominator = int.Parse(Console.ReadLine()); //0

                try
                {
                    Console.WriteLine($"{numerator}/{denominator}={(numerator / denominator)}");
                    ok = true;
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("No way Hoze you just can't do that. Zero is not divisible");
                }
            }
            Console.WriteLine("Thanks for playing, enter any key to end");

            Console.ReadKey();
        }
    }
}
