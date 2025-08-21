using System;

namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Printing numbers using recursion
            int x = 3;
            fun1(x);
            Console.WriteLine(); // to add a new line after the recursion output

            // Part 2: Calculating factorial
            int fact, num;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Calling recursive factorial function
            fact = factorial(num);

            Console.WriteLine("Factorial of {0} is {1}", num, fact);

            Console.ReadKey();
        }

        // Function for printing numbers in reverse order
        static void fun1(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                fun1(n - 1);
            }
        }

        // Recursive function to calculate factorial
        public static int factorial(int num)
        {
            // Base condition to stop recursion
            if (num == 0)
                return 1;
            else
                return num * factorial(num - 1);
        }
    }
}
