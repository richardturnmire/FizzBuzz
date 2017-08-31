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
            //TODO:  Implement FizzBuzz
            //Write a loop that outputs the numbers from 1 to 100 in the console.
            //If the number is a multiple of 3, print the word “Fizz” next to the number.
            //If the number is a multiple of 5, print the word “Buzz” next to the number.
            //If it is both, print “FizzBuzz” next to the number.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i + " Fizz");
                    }

                    else
                    {
                        if (i % 5 == 0)
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
    }
}
