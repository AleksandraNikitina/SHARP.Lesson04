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

double[] GetAverageRowsToArray(int[,] matrix)
{
    double[] avarageRowsElem = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumElemInRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElemInRow = sumElemInRow + matrix[i, j];
        }
        avarageRowsElem[i] = (double)sumElemInRow / matrix.GetLength(1);
    }
    return avarageRowsElem;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]:F2} ");    // :F2 - округление до указанного количества знаков после запятой 
    }
    Console.WriteLine($"{array[array.Length - 1]:F2}]");

}

int[,] arrayd2 = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(arrayd2);
Console.WriteLine();

double[] resultArray = GetAverageRowsToArray(arrayd2);
PrintArray(resultArray);
