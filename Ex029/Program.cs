// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите длину создаваемого массива: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите нижную границу интервала чисел для заполнения массива: ");
int lowLimit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхнюю границу интервала чисел для заполнения массива: ");
int upLimit = Convert.ToInt32(Console.ReadLine());

int[] array = CreatArray(lengthArray, lowLimit, upLimit);

OutArray(array);


int[] CreatArray(int arrLength, int limLow, int limUp)
{
    int[] arr = new int[arrLength];
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(limLow, limUp + 1);

    }
    return arr;
}


void OutArray(int[] arr)
{
    Console.Write("Созданный массив: [");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < (arr.Length - 1)) Console.Write(", ");
    }
    Console.WriteLine("]");

}