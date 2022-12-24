// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) PrintSqrtOfNumber(number);
else Console.WriteLine("Введено не натуральное число");


void PrintSqrtOfNumber(int num)
{
    Console.WriteLine("число   квадрат");
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i,2}   {i * i * i}");
        i++;
    }


}
