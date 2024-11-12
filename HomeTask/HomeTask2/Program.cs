// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строки массива.

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

void ChancheFirstAndLastStringsOfMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[matrix.GetLength(0)-1,j];
        matrix[matrix.GetLength(0)-1,j] = matrix[0,j];
        matrix[0,j] = temp;
    }
}

int[,] arrayd2 = CreateMatrixRndInt(6, 5, 1, 10);
PrintMatrix(arrayd2);
Console.WriteLine();
ChancheFirstAndLastStringsOfMatrix(arrayd2);
PrintMatrix(arrayd2);