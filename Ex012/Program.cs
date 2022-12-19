// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());



string Multiplicity(int num1, int num2)
{
    int result = (num1 % num2);
    string res = "";
    if ((num1 % num2) == 0) res = "Кратно";
    else res = "Не кратно, остаток " + result;
    return res;
    
}
Console.WriteLine (Multiplicity(number1, number2));