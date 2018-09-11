using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.PracticeSession
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool keepGoing = true;

            while(true)
            {
                Console.WriteLine("Enter a number between 1 and 1000: ");
                string entry = Console.ReadLine();


                if (entry.ToLower() == "quit")
                {
                    break;
                }

                try
                {
                    double number = double.Parse(entry);
                    if (number <= 0)
                    {
                        Console.WriteLine("Please enter a number greater than 0.");
                        continue;
                    }
                    else if (number > 1000)
                    {
                        Console.WriteLine("Please enter a number less than or equal to 1000.");
                        continue;
                    }
                    else
                    {
                        double result = number * number;
                        Console.WriteLine(number + " multiplied by itself is equal to " + result + ".");
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("'" + entry + "' is not a number!");
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
