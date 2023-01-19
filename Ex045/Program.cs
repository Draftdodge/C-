// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int[] CopyArray(int[] arr)
{
    int[] arrNew = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrNew[i] = arr[i];
    }
    return arrNew;
}

int[] arrayOrigin = CreateArrayRndInt(5, 0, 10);
PrintArray(arrayOrigin);
int[] copyArray = CopyArray(array);
PrintArray(copyArray);
