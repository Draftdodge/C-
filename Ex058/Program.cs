// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductOfMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
        for (int m = 0; m < resultMatrix.GetLength(1); m++)
            for (int j = 0; j < firstMatrix.GetLength(1); j++)
                resultMatrix[i, m] += firstMatrix[i, j] * secondMatrix[j, m];

    return resultMatrix;
}




int[,] firstArray2d = CreateMatrixRndInt(4, 3, 1, 5);
int[,] secondArray2d = CreateMatrixRndInt(2, 3, 1, 5);
Console.WriteLine("Исходная матрица 1: ");
PrintMatrix(firstArray2d);
Console.WriteLine();
Console.WriteLine("Исходная матрица 2: ");
PrintMatrix(secondArray2d);
Console.WriteLine();
if (firstArray2d.GetLength(1) == secondArray2d.GetLength(0))
{
    Console.WriteLine("Произведение матрицы 1 и матрицы 2: ");
    int[,] productOfMatrix = ProductOfMatrix(firstArray2d, secondArray2d);
    PrintMatrix(productOfMatrix);
}
else
{
    Console.WriteLine("Число столбцов первой матрицы не равно числу строк второй.");
    Console.Write("Перемножение невозможно.");
}