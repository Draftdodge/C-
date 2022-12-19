// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (BootMultiple(number) ? "Да" : "нет");


bool BootMultiple (int num, int num1 = 7, int num2 = 23)
{
return (num % num1 == 0) && (num % num2 == 0);
}
