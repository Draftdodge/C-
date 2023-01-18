// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)  
{
    double[] arr = new double[size];
    var rnd = new Random();  
    for (int i = 0; i < arr.Length; i++)
    {
        double number = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(number, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + " , ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double FindMinElement(double[] arr)
{
    double minElem = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[i-1]) minElem = arr[i];
    }
    return minElem;
}

double FindMaxElement(double[] arr)
{
    double maxElem = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[i-1]) maxElem = arr[i];
    }
    return maxElem;
}

double DiffMinMax(double min, double max)
{
    double result = max - min;
    return result;
}


double[] array = CreateArrayRndDouble(7, 1, 100);
PrintArray(array);
double minElementArray = FindMinElement(array);
double maxElementArray = FindMaxElement(array);
double differentMaxMin = DiffMinMax(minElementArray, maxElementArray);
Console.WriteLine($"Минимальный элемент массива = {minElementArray}");
Console.WriteLine($"Максимальный элемент массива = {maxElementArray}");
Console.WriteLine($"Разница между максимальным и минимальным элементами = {differentMaxMin}");