// Задайте двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
    Console.WriteLine();
}

int[] GetSumOfRowsToArray(int[,] matrix)
{
    int[] sumRowsElem = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRowsElem[i] = sumRowsElem[i] + matrix[i,j];
        }
    } 
    return sumRowsElem;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i],5}");
    }
    Console.Write("   ]");
    Console.WriteLine();
}

int FindIndexOfMinElement(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] arrayd2 = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(arrayd2);

int[] array = GetSumOfRowsToArray(arrayd2);
PrintArray(array);

int rowIndex = FindIndexOfMinElement(array);
Console.WriteLine($"String with min summary of elements index is {rowIndex}.");