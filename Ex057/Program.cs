// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.



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

void PrintDict(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} ->");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("]");


    }
}


int[] Creat1dArray(int[,] matrix)
{
    int[] tempArray = new int[matrix.GetLength(1) * matrix.GetLength(0)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempArray[k] = matrix[i, j];
            k++;
        }
    }
    Array.Sort(tempArray);
    return tempArray;
}

int[,] CreatDict(int[] arr)
{
    int differentElements = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] != arr[i - 1]) differentElements++;
    }
    int[,] dict = new int[differentElements, 2];
    dict[0, 0] = arr[0];
    dict[0, 1] = 1;
    int j = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == arr[i - 1])
        {
            dict[j, 1]++;
        }
        else
        {
            j++;
            dict[j, 0] = arr[i];
            dict[j, 1] = 1;
        }
    }
    return dict;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[,] array2d = CreateMatrixRndInt(4, 3, -7, 7);
Console.WriteLine("Исходная матрица: ");
PrintMatrix(array2d);
Console.WriteLine();
int[] array = Creat1dArray(array2d);
Console.WriteLine("Упорядоченный одномерный массив из элементов матрицы: ");
PrintArray(array);
Console.WriteLine();
int[,] dictResult = CreatDict(array);
Console.WriteLine("Печать словаря:");
PrintDict(dictResult);
*/
// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random(); // var когда в правой части ясно какой тип данных мы используем
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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintDict(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        Console.Write($"{matrix[i, 0],4} -> {matrix[i, 1],4}");
        Console.WriteLine("|");
    }
}

int[] MatrixInArray(int[,] matrix)
{
    int z = 0;
    int[] array = new int[(matrix.GetLength(0) - 1) * (matrix.GetLength(1) - 1)];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            array[z] = matrix[i, j];
            z++;

        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
}

int[,] RepetitionDictionary(int[] arr)
{
    int[,] arResult = new int[arr.Length, 2];
    int count = 1;
    int a = 0;
    arResult[a, 0] = arr[0];
    for (int i = 0; i < arr.Length - 1; i++)
    {

        if (arr[i] == arr[i + 1]) count++;
        else if (arr[i] != arr[i + 1])
        {
            arResult[a + 1, 0] = arr[i + 1];
            arResult[a, 1] = count;
            a++;
            count = 1;
        }
        if (arr[i] == arr[i + 1] || i + 1 == arr.Length - 1) arResult[a, 1] = count;
    }
    return arResult;
}

int[,] FinalDictionary(int[,] matrix)
{
    int m = 0;
    for (int i = matrix.GetLength(0) - 1; i > 0; i--)
    {
        if (matrix[i, 1] == 0) m++;
    }
    int[,] result = new int[matrix.GetLength(0) - m, 2];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = matrix[i, j];
        }
    }
    return result;
}



var rnd = new Random(); 
int row = rnd.Next(5, 50);
int column = rnd.Next(5, 50);

// int row = 10;
// int column = 10;

int[,] array2D = CreateMatrixRndInt(row, column, -9, 99);
PrintMatrix(array2D);
int[] newArray = MatrixInArray(array2D);
Array.Sort(newArray);
// PrintArray(newArray);
System.Console.WriteLine();
int[,] repetitionDictionary = RepetitionDictionary(newArray);
// PrintMatrix(repetitionDictionary);
System.Console.WriteLine();
int[,] dictionary = FinalDictionary(repetitionDictionary);
PrintDict(dictionary);