// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
Console.WriteLine("Введите число от 1 до 7 и программа выведет название соответствующего дня недели");
int day_number = Convert.ToInt32(Console.ReadLine());
int i = 1;
if ((day_number > 0)&&(day_number < 8))
{
    do
    {
        if (day_number == i)
        {
            if (day_number == 1)
            {
                Console.WriteLine($"цифре {day_number} соответствует день недели Понедельник");
            }
            if (day_number == 2)
            {
                Console.WriteLine($"цифре {day_number} соответствует день недели Вторник");
            }
            if (day_number == 3)
            {
                Console.WriteLine($"цифре {day_number} соответствует день недели Среда");
            }
            if (day_number == 4)
            {
                Console.WriteLine($"цифре {day_number} соответствует день недели Четверг");
            }
            if (day_number == 5)
            {
                Console.WriteLine($"цифре {day_number} соответствует день недели Пятница");
            }
            if (day_number == 6)
            {
                Console.WriteLine($"цифре {day_number} соответствует день недели Суббота");
            }
            if (day_number == 7)
            {
                Console.WriteLine($"цифре {day_number} соответствует день недели Воскресенье");
            }
        }
        i = i + 1;
    } while ((i == day_number)||(i == 8));
}
else
{
    Console.WriteLine($"Введенное число {day_number} не соответствует дню недели");    
}