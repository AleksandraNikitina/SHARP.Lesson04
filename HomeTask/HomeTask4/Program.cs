﻿// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива. 
// Под удалением понимется создание нового двумерного массива без строки и столбца.

using System.Data;
using System.Numerics;

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

int[] FindMinElementIndexes(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] indexesArray = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexesArray[0] = i;
                indexesArray[1] = j;
            }
        }
    }
    return indexesArray;
}

int[,] DeleteRowAndColumnFromMatrix(int[,] matrix, int rowIndex, int columnIndex)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {

        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j >= columnIndex && i < rowIndex)
            {
                newMatrix[i, j] = matrix[i, j + 1];
            }
            else if (j >= columnIndex && i >= rowIndex)
            {
                newMatrix[i, j] = matrix[i + 1, j + 1];
            }
            else if (j < columnIndex && i >= rowIndex)
            {
                newMatrix[i, j] = matrix[i + 1, j];
            }
            else
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }
    }
    return newMatrix;
}


int[,] arrayd2 = CreateMatrixRndInt(7, 6, 1, 10);
PrintMatrix(arrayd2);

int[] indexes = FindMinElementIndexes(arrayd2);
Console.WriteLine($"Indexes of min element is [{indexes[0]},{indexes[1]}].");

int[,] resultMatrix = DeleteRowAndColumnFromMatrix(arrayd2, indexes[0], indexes[1]);
PrintMatrix(resultMatrix);