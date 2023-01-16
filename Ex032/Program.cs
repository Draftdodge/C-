// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.Write("Введите длину создаваемого массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижную границу интервала чисел для заполнения массива: ");
int lowLimit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнюю границу интервала чисел для заполнения массива: ");
int upLimit = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(lengthArray, lowLimit, upLimit);
PrintArray(array);
InvertArray(array);
PrintArray(array);



int[] CreateArray(int arrLength, int limLow, int limUp)
{
    int[] arr = new int[arrLength];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {    
        arr[i] = rnd.Next(limLow, limUp + 1);

    }
    return arr;
}

void InvertArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= arr[i] * (-1);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("Созданный массив: [");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < (arr.Length - 1)) Console.Write(", ");
    }
    Console.WriteLine("]");

}