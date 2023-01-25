// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого элемента в массиве нет


double[,] CreateMatrixRndDouble(int minRowsColums, int maxRowsColumns, int minElem, int maxElem)
{

    var rnd = new Random();
    int rows = rnd.Next(minRowsColums, maxRowsColumns + 1);
    int columns = rnd.Next(minRowsColums, maxRowsColumns + 1);
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (maxElem - minElem) + minElem;
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }

    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} ");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");


    }

}

double SearchElemInMatrix(double[,] matrix, int rowNumber, int columnNumber)
{
    double result = 0;
    if ((matrix.GetLength(0) > rowNumber) && (matrix.GetLength(1) > columnNumber))
    {
        result = matrix[rowNumber - 1, columnNumber - 1];
    }
    return result;
}



Console.Write("Введите номер строки: ");
int rowEnter = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columnEnter = Convert.ToInt32(Console.ReadLine());
double[,] matrixGlobal = CreateMatrixRndDouble(1, 10, -10, 10);
Console.WriteLine();
PrintMatrix(matrixGlobal);
Console.WriteLine();
if (rowEnter > 0 && columnEnter > 0)
{
    double searchElem = SearchElemInMatrix(matrixGlobal, rowEnter, columnEnter);

    if (searchElem != 0) Console.WriteLine($"Найденный элемент {searchElem}.");
    else Console.WriteLine("Такого элемента в массиве нет.");
}
else Console.WriteLine("Введены некоректные данные.");