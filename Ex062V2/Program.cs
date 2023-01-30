// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixSpiral(int size, int min)
{
    int[,] matrix = new int[size, size];
    matrix[0, 0] = min;
    int sp = 0; // spiral counter // счетчик оборотов спирали
    CreateSpiral(matrix, size, sp);
    if (matrix[size / 2, size / 2] == 0) matrix[size / 2, size / 2] = matrix[size / 2, size / 2 - 1] + 1;
    return matrix;
}

void CreateSpiral(int[,] matrix, int size, int sp)
{
    for (int j = 1 + sp; j < size - sp; j++)
    {
        if (matrix[sp, j - 1] == 0)
        {
            matrix[sp, j] = matrix[sp, j - 2];
            j--;
        }
        else matrix[sp, j] = matrix[sp, j - 1];
        matrix[sp, j] = matrix[sp, j - 1];
        matrix[sp, j]++;
    }
    for (int i = 1 + sp; i < size - sp; i++)
    {
        matrix[i, size - sp - 1] = matrix[i - 1, size - sp - 1];
        matrix[i, size - sp - 1]++;
    }
    for (int j = size - 2 - sp; j >= 0 + sp; j--)
    {
        matrix[size - sp - 1, j] = matrix[size - sp - 1, j + 1];
        matrix[size - sp - 1, j]++;
    }
    for (int i = size - sp - 2; i > 0 + sp; i--)
    {
        matrix[i, 0 + sp] = matrix[i + 1, 0 + sp];
        matrix[i, 0 + sp]++;
    }
    if (sp < size / 2) CreateSpiral(matrix, size, sp + 1);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{i + 1,4}.|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

Console.WriteLine("Ведите размер спирали");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите начало спирали массива");
int min = int.Parse(Console.ReadLine());

int[,] array2D = CreateMatrixSpiral(size, min);
PrintMatrix(array2D);