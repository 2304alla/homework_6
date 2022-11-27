﻿// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] CreateMatrix(int rows, int columns,int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}| ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }

}

int SumElementMatrix(int[,] matrix)
{
    int count = default;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++) 
    {
        count += matrix[i, i];
    }

    return count;
}

int[,] arraY2D = CreateMatrix(3, 4, 1, 9);
PrintMatrix(arraY2D);
Console.WriteLine();

int sumElem = SumElementMatrix(arraY2D);
Console.WriteLine($"Сумма элементов на главной диагонали = {sumElem}");



//   int count=matrix[0,0]+matrix[0,0];
//   for (int i = 1; i < matrix.GetLength(0); i++)

//     {
//         for (int j = 1; j < matrix.GetLength(1); j++)
//         {
//           if (i==j) count+=matrix[i,j];
//         }
//     }  