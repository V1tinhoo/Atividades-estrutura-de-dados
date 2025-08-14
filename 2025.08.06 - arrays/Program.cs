using System;
using System.Globalization;

Console.WriteLine("Hello, World!");
Console.WriteLine("");

Console.WriteLine("Informe seu nome:");
string? name = Console.ReadLine();

Console.WriteLine(name);

int[] numbers;

// Inicializando vetor
numbers = new int[5];

int[] numbers2 = new int[5];

// Atribuindo Valores
numbers2[0] = 1;
numbers2[1] = 2;
numbers2[2] = 3;
numbers2[3] = 4;
numbers2[4] = 5;

// Declarando e inicializando com valores
int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };

// Simplificada
int[] numbers4 = { 1, 2, 3, 4, 5 };

// Preenchendo um vetor com os 12 meses do ano
string[] months = new string[12];
for (int i = 1; i <= 12; i++)
{
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);
    string monthName = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
    months[i - 1] = monthName;
}

foreach (var month in months)
{
    Console.WriteLine(month);
}




// 3 dimensões

int[,,] numbers


// Inicializando matriz valorada
int[,] number = new int[,]{
    {1, 2, -9},
    {5, 7, 10}
    {6, 115, 54}
};

// Também podemos acessar a matriz da seguinte maneira

int myNumber = number[2, 1];
Console.WriteLine("Imprimindo valor da matriz");
Console.WriteLine(myNumber)
