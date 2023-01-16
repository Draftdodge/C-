// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt(int size, int min, int max)  //сигнатура метода
{
    int[] arr = new int[size];
    var rnd = new Random();  //неявная типизация (когда справа понятно что за тип переменной)
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

int GetSumElemArray(int[] arr, int type)
{
    int result = 0;
    if (type > 0)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) result += arr[i];
        }
    }
    else
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0) result += arr[i];
        }
    }
    return result;
}
//14-20, 675 каб, паспорт
//return new int[]{1ый элемент, 2ой элемент}


int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int sumNegativ = GetSumElemArray(array, -1);
int sumPozitiv = GetSumElemArray(array, 1);
Console.WriteLine($"Сумма Отриц элем = {sumNegativ}");
Console.WriteLine($"Сумма полож элем = {sumPozitiv}");