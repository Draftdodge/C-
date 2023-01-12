// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int productNumbers = ProductNumbers(number); ;
    Console.WriteLine("Факториал числа " + number + " = " + productNumbers);
}
else Console.WriteLine("Введеное число меньше либо равно 0");

int ProductNumbers(int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
        checked  // проверка на переполнение
        {
            res = res * i;
        }
    }
    return res;
}
