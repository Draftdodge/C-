// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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

int SumElemDiag(int[,] matrix)
{
    int sum = 0;   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(i == j) sum += matrix[i,j];
            }

    }
    return sum;
}

int SumElemDiag2(int[,] matrix)
{
    int sum = 0;
    if (matrix.GetLength(0) >= matrix.GetLength(1))
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[i, i];
        }
    else
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }
    return sum;
}



    int[,] matrixGlobal = CreateMatrixRndInt(3, 4, 0, 5);
    PrintMatrix(matrixGlobal);
    int summElemDiag = SumElemDiag(matrixGlobal);
    Console.WriteLine($"Summ of diagonal element is: {summElemDiag}:");