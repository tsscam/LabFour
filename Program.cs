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
        {
            Console.WriteLine("Learning Factorials");
            Console.WriteLine("()()()()()()()()()()()()()()()()()()()()()");
            Console.WriteLine("Please enter any number between 1 and 25: ");
            long factorial = 1;
            string Continue;
            int number;
            int min = 1;
            int max = 25;


            // Loop if User Chooses to Continue
            bool run = true;
            do

            {
                number = GetRange(min, max);
                // Process - For Loop Decrements to Get Integers Before Number Entered to Find Factorial
                factorial = number;


                for (long i = number - 1; i >= 1; i--)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("The Factorial of " + number + " is:  " + factorial);
                Console.WriteLine();
                Console.WriteLine("Do you want to continue?");

                string input = Console.ReadLine();


                //Continue Loop

                {
                    Console.WriteLine("Continue?  (y/n)");
                    Continue = Console.ReadLine().ToUpper();

                    if (Continue == "Y")
                        break;

                    if (Continue == "N")
                        return;
                }

            } while (run);
        }

        // Method to Get Input and Validate Range 1 - 25
        public static int GetRange(int min, int max)
        {
            int input = GetValidInt();
            while (input < min || input > max)
            {
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                input = GetValidInt();
            }
            return input;
        }
        // Method to Validate Input
        public static int GetValidInt()
        {
            int number;
            // Validate Input1
            while (!int.TryParse(Console.ReadLine(), out number))
            {


            }
            return number;
        }
    }

}