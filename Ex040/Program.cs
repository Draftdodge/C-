// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


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

bool IfExistTriangl(int[] arr)
{
    if ((arr[0] + arr[1] > arr[2])
    && (arr[1] + arr[2] > arr[0])
    && (arr[0] + arr[2] > arr[1]))
    {
        return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(3, 1, 10);
PrintArray(array);
if (IfExistTriangl(array) == true) Console.Write("Существует");
else Console.WriteLine("НЕ существует");

Console.WriteLine(IfExistTriangl(array) ? "существует" : "Не существует");