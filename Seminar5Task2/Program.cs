// Задайте двумерный массив.
// Найдие сумму элементов, находящихся на главной диагонали.

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

int GetSumElemMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int diagonalSize = matrix.GetLength(0);
    if (matrix.GetLength(0)>matrix.GetLength(1))
    {
        diagonalSize = matrix.GetLength(1);
    }
    // or: for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++) 
     
    for (int i = 0; i < diagonalSize; i++)
    {
        sum = sum + matrix[i,i];
    }
    return sum;
}

int[,] arrayd2 = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(arrayd2);
Console.WriteLine();

// int result = GetSumElemMainDiagonal(arrayd2);
// Console.WriteLine($"Sum of elements of the main diagonal is {result}.");

Console.WriteLine($"Sum of elements of the main diagonal is {GetSumElemMainDiagonal(arrayd2)}.");