// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.Writeline("Введите целое число:");
int number = Convert.ToInt32(Console.Readline());
int square = number * number;
Console.Writeline($"Квадрат числа {number} = {square}");
