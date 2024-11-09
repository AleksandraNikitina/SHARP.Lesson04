// Задайте двумерный массив из целых чисел.
// Сформируйте новый одномерный массив, состоящий из 
// средних арифметических значений по строкам двумерного массива.

// Пример: 

// 2 3 4 3
// 4 3 4 1
// 2 9 5 4

// => [3 3 5]

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