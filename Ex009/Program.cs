// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10,100);
Console.WriteLine(number);
Console.WriteLine("Искомая цифра:" + number);
int first_digit = number/10;
int second_digit = number%10;

if (first_digit>second_digit)
{
    Console.WriteLine("Наибольшая цифра числа  - " + first_digit);
}
else 
{
    Console.WriteLine("Наибольшая цифра числа  - " + second_digit);
}

// тернарный оператор. Если условие то (?) если верно: если лож
int result = first_digit > second_digit ? first_digit:second_digit;
Console.WriteLine("Наибольшая цифра числа  - " + result);

int maxDigit = MaxDigit(number);

int MaxDigit(int num) //num = number
{
    int first_digit = num/10;
    int second_digit = num%10;
    return first_digit > second_digit ? first_digit:second_digit;
}
Console.WriteLine("Наибольшая цифра числа  - " + maxDigit);
Console.WriteLine("Наибольшая цифра числа  - " + MaxDigit(number));

//Все методы в одном месте - либо вверху либо внизу