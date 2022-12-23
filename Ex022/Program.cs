// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


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
        Console.WriteLine($"{i,2}   {i * i,5}");
        i++;
    }


}
