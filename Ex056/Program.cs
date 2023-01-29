// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SummElementsOfRow(int[,] matrix)
{
    int[] summArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summArray[i] += matrix[i, j];
        }
    }
    return summArray;
}

int MinElement(int[] arr)
{
    int minElemOfArrow = arr[0];
    int numberMinElemArrow = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElemOfArrow) numberMinElemArrow = i;
    }
    return numberMinElemArrow;
}


int[,] array2d = CreateMatrixRndInt(4, 3, 1, 7);
Console.WriteLine("Исходная матрица: ");
PrintMatrix(array2d);
Console.WriteLine();
int[] array = SummElementsOfRow(array2d);
int minRowOfMatrix = MinElement(array);
Console.Write($"Номер строки с минимальной суммой элементов: {minRowOfMatrix + 1}");
