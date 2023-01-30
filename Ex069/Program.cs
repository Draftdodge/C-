// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число основания: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число степени: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Exponentiation(firstNumber, secondNumber));

int Exponentiation(int firstNum, int secondNum)
{
    if (secondNum == 0) return 1;
    return firstNum * Exponentiation(firstNum, secondNum - 1);
}
