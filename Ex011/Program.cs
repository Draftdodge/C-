// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100,1000);
Console.WriteLine("Искомое число - " + number);

int Remove(int num)
{
    int first_digit = num /100;
    int second_digit = num % 10;
    int result = first_digit*10 + second_digit;
    return result;
}

Console.WriteLine(Remove(number));