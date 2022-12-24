// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 10000) && (number < 99999))
{
    Console.WriteLine(Palindrom(number) ? "Введеное число палиндром"
                                        : "Введенное число не палиндром"
                                        );
}
else Console.WriteLine("Введено не пятизначное число.");


bool Palindrom(int num)
{
        int remains = num;
        int newNum = 0;
        int temp = 0;
        do
        {
            temp = remains % 10;
            newNum = newNum * 10 + temp;
            remains = remains / 10;
        } while (remains > 0);
        if (num == newNum) return true;
    return false;
}