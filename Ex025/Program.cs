// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int digitA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int digitB = Convert.ToInt32(Console.ReadLine());

if (digitB > 0)
{
    int exponentiation = Exponentiation(digitA, digitB);
    Console.WriteLine("Число " + digitA + " в степени " + digitB + " = " + exponentiation);
}
else Console.WriteLine("Введенное число B не является натуральным");


int Exponentiation(int digit1, int digit2)
{
    int result = digit1;
    for (int i = 1; i < digit2; i++)
    {
        result = result * digit1;
    }

    return result;
}