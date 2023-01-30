// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if ((numberM > 0) && (numberN > 0))
{
    if (numberN < numberM) Console.WriteLine(SumNumber(numberN, numberM));
    else Console.WriteLine(SumNumber(numberM, numberN));
}
else Console.WriteLine("Введенное число не натуральное");


int SumNumber(int numM, int numN)
{
    if (numN == numM) return numM;
    return numN + SumNumber(numM, numN - 1);
}
