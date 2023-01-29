// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");


    }
}

void SortRowsMatrix(int[,] matrix)
{
    int temp;
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        temp = 0;
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                if (matrix[k, j] < matrix[k, j + 1])
                {
                    temp = matrix[k, j + 1];
                    matrix[k, j + 1] = matrix[k, j];
                    matrix[k, j] = temp;
                }
    }

}

int[,] array2d = CreateMatrixRndInt(5, 5, -10, 10);
Console.WriteLine("Исходная матрица:");
PrintMatrix(array2d);

SortRowsMatrix(array2d);
Console.WriteLine("Матрица со строками отсортированными по убыванию:");
PrintMatrix(array2d);

