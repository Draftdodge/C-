// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultiplicationOfElementArray(int[] arr)
{
    int size = 0;
    if ((arr.Length % 2) == 0) size = arr.Length / 2;
    else size = arr.Length / 2 + 1;
    int[] resultArr = new int[size];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        resultArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if ((arr.Length % 2) != 0) resultArr[resultArr.Length - 1] = arr[arr.Length / 2 + 1];
    return resultArr;
}


int[] array = CreateArrayRndInt(10, 1, 5);
PrintArray(array);
int[] multiplicationOfElementArray = MultiplicationOfElementArray(array);
PrintArray(multiplicationOfElementArray);