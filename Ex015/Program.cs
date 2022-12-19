

// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, 
//  является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int numberDay = Convert.ToInt32(Console.ReadLine());

Console.Write(numberDay + " -> ");
Console.Write(WeekEndCheck(numberDay) ? "Да" : "Нет");

bool WeekEndCheck(int numDay)
{
    bool weekEnd = false;
    if (numDay == 6 || numberDay == 7) weekEnd = true;
    return weekEnd;
}