Console.Write("Enter the lenght of the Finabonacci Series: ");
int lenght = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < lenght; i++)
{
    Console.Write("{0} ", FinabonacciSeries(i));
}
Console.ReadKey();

static int FinabonacciSeries(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return FinabonacciSeries(n - 1) + FinabonacciSeries(n - 2);
}

// recursive fuction

static int factorial(int num)
{
        // termination condition
        if (num == 0)
            return 1;
        else
        // recursive call
            return num * factorial(num - 1);
}