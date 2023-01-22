// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] Fibonachi(int size, int firstDigit, int secondDigit)
{
    int[] arr = new int[size];
    arr[0] = firstDigit;
    arr[1] = secondDigit;
    for (int i = 2; i < size; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
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


Console.WriteLine("Введите какое количество чисел хотате вывести");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = Fibonachi(7, 0, 1);

Console.Write($"Если N = {number} ->");
PrintArray(array);

