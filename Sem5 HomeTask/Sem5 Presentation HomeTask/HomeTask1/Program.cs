// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System.Linq.Expressions;

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");   // 5 - длина строки
        }
        Console.WriteLine();
    }
}

int[,] arrayd2 = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(arrayd2);
Console.WriteLine();

Console.Write("Enter the first index of element: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second index of element: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i<arrayd2.GetLength(0)&& j<arrayd2.GetLength(1))
{
    Console.WriteLine($"Element[{i},{j}] = {arrayd2[i,j]}");
}
else 
{
    Console.WriteLine($"There is no element with index [{i},{j}]");
}
