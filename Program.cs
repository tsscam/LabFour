using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4b
{
    class Program
    {
        static void Main(string[] args)
        {   // calculates factorials of 0 - 10
            int number;
                        
            {
                Console.WriteLine("Please enter any number between 1 and 10: ");
                for(int i = 1; i <= 10; ++i)
                Console.WriteLine($" {i}! = {Factorial(i)}");
            }
        }
        static long Factorial(long number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
                
            }
        }
    }
}
