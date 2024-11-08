// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты.

//   2 3 4 3
//   4 3 4 1 
//   2 9 5 4 

//   =>

//   4 3 16 3
//   4 3 4 1 
//   4 9 25 4

using System.Data;
using System.Text.RegularExpressions;

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
            Console.Write($"{matrix[i, j],5}");   // 4 - длина строки
        }
        Console.WriteLine();
    }
}

void ElemEvenIndexesTpoSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)       //  i = i+2, тогда не нужно условие
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)   //  j = j+2, тогда не нужно условие
        {
            // if (i % 2 == 0 && j % 2 = 0)
            // {
                matrix[i,j] *=matrix[i,j];
            // }
        }
    }
}

int[,] arrayd2 = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(arrayd2);
Console.WriteLine();
ElemEvenIndexesTpoSquare(arrayd2);
PrintMatrix(arrayd2);

