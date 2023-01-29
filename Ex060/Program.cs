// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateArray3dRndUniqueInt(int rows, int columns, int depth, int min, int max)
{
    int[] arr = new int[rows * columns * depth];
    var rnd = new Random();
    int temp = 0;
    int repeat = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        do
        {
            repeat = 0;
            temp = rnd.Next(min, max + 1);
            for (int j = 0; j < i; j++)
            {
                if (arr[j] == temp)
                {
                    repeat = 1;
                    break;
                }
            }
        }
        while (repeat != 0);
        arr[i] = temp;
    }
    //   Array.Sort(arr);
    //   PrintArray(arr);          //контроль на уникальность элементов
    int[,,] arr3d = new int[rows, columns, depth];
    int l = 0;
    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
                arr3d[i, j, k] = arr[l];
                l++;
            }
        }

    }
    return arr3d;
}

void PrintArray3d(int[,,] arr3d)
{

    for (int i = 0; i < arr3d.GetLength(0); i++)
    {
        for (int j = 0; j < arr3d.GetLength(1); j++)
        {
            for (int k = 0; k < arr3d.GetLength(2); k++)
            {
                Console.Write($"{arr3d[i, j, k],5} ({i},{j},{k})");

            }
            Console.WriteLine();
        }
        Console.WriteLine();


    }
}

/*
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
*/

int rows3d = 2;
int colunms3d = 2;
int depth3d = 2;
int minDigit = 10;
int maxDigit = 16;

if ((rows3d * colunms3d * depth3d < 90) && (minDigit >= 10) && (maxDigit <= 99) && ((maxDigit - minDigit + 1) >= (rows3d * colunms3d * depth3d)))
{
    int[,,] array3d = CreateArray3dRndUniqueInt(rows3d, colunms3d, depth3d, minDigit, maxDigit);
    PrintArray3d(array3d);
}
if (rows3d * colunms3d * depth3d >= 90) Console.WriteLine("Размер элементов в трехмерном массиве больше допустимого.");
if ((minDigit < 10) || (maxDigit > 99)) Console.WriteLine("Интервал чисел, для заполения массива, не соответствует допустимому.");
if ((maxDigit - minDigit + 1) < (rows3d * colunms3d * depth3d)) Console.WriteLine("Количество элементов недостаточно для заполнения массива.");