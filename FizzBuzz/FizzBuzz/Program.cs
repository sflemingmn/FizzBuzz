using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
            Console.ReadLine();
        }

        static void Execute()
        {
            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + " FizzBuzz");

                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
