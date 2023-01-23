// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4






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

void ReplaceElemSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(j % 2 == 0) matrix[i,j] = matrix[i,j]*matrix[i,j];
            }
        }

    }
}


    int[,] matrixGlobal = CreateMatrixRndInt(3, 4, 0, 10);
    PrintMatrix(matrixGlobal);
    ReplaceElemSquare(matrixGlobal);
    Console.WriteLine();
    PrintMatrix(matrixGlobal);