// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = new Random().Next(1,20000);
Console.Write("Искомое число - " + number);

if (ThirdDigit(number) == -1) Console.WriteLine(" -> третьей цифры нет");
else Console.WriteLine(" -> " + ThirdDigit(number));

int ThirdDigit(int initNumber)
{
    int result = 0;
    if (initNumber < 99) result = -1;
    else    
    {
            while (initNumber > 999) 
            {
                initNumber = initNumber/10;
            }
            result = initNumber % 10;

    }
    return result;
}

