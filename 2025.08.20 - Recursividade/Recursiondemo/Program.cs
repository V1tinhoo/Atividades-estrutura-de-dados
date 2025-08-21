using System;

namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parte 1: Demonstração de chamadas de funções recursivas
            Console.WriteLine("Main Method Started");
            fun1(4);
            Console.WriteLine("Main Method Ended");
            Console.ReadKey();

            // Parte 2: Cálculo do fatorial
            int fact, num;
            Console.Write("\nEnter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            Program obj = new Program();
            fact = obj.factorial(num);

            Console.WriteLine("Factorial of {0} is {1}", num, fact);
        }

        // Funções recursivas para o primeiro exemplo
        static void fun1(int n)
        {
            Console.WriteLine("Fun1 Started");
            fun2(3);
            Console.WriteLine("Fun1 Ended");
        }

        static void fun2(int n)
        {
            Console.WriteLine("Fun2 Started");
            fun3(2);
            Console.WriteLine("Fun2 Ended");
        }

        static void fun3(int n)
        {
            Console.WriteLine("Fun3 Started");
            fun4(1);
            Console.WriteLine("Fun3 Ended");
        }

        static void fun4(int n)
        {
            Console.WriteLine("Fun4 Started");
            Console.WriteLine("Fun4 Ended");
        }

        // Função recursiva para cálculo do fatorial
        public int factorial(int num)
        {
            // Condição de terminação
            if (num == 0)
                return 1;
            else
                // Chamada recursiva
                return num * factorial(num - 1);
        }
    }
}
