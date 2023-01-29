// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int k = 1;
    int lastRun = 0;
    if (matrix.GetLength(1) < matrix.GetLength(0)) lastRun = matrix.GetLength(1) / 2;
    else lastRun = matrix.GetLength(0) / 2;
    for (int i = 0; i < lastRun; i++)
    {
        for (int j = i; j < matrix.GetLength(1) - 1 - i; j++) //направо
        {
            matrix[i, j] = k;
            k++;
        }
        for (int j = i; j < matrix.GetLength(0) - 1 - i; j++) //вниз
        {
            matrix[j, matrix.GetLength(1) - i - 1] = k;
            k++;
        }
        for (int j = i; j < matrix.GetLength(1) - 1 - i; j++) //налево
        {
            matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(1) - j - 1] = k;
            k++;
        }
        for (int j = i; j < matrix.GetLength(0) - 1 - i; j++) //вверх
        {
            matrix[matrix.GetLength(0) - j - 1, i] = k;
            k++;
        }
    }
    if ((matrix.GetLength(1) < matrix.GetLength(0)) && (matrix.GetLength(1) % 2 != 0))
    {
        for (int j = lastRun; j < matrix.GetLength(0) - lastRun; j++) //вниз
        {
            matrix[j, matrix.GetLength(1) - lastRun - 1] = k;
            k++;
        }
    }
    if ((matrix.GetLength(1) > matrix.GetLength(0)) && (matrix.GetLength(0) % 2 != 0))
    {
        for (int j = lastRun; j < matrix.GetLength(1) - lastRun; j++) //направо
        {
            matrix[lastRun, j] = k;
            k++;
        }
    }
    if ((matrix.GetLength(1) == matrix.GetLength(0)) && (matrix.GetLength(0) % 2 != 0))
    {
        matrix[matrix.GetLength(0) / 2, matrix.GetLength(1) / 2] = k;
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

int[,] array2d = CreateMatrix(5, 5);
PrintMatrix(array2d);