Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > number1)
{
    Console.WriteLine("Число: " + number2 + " больше чем " + number1);
}
if (number1 > number2)
{
    Console.WriteLine("Число: " + number1 + " больше чем " + number2);    
}
if (number1 == number2)
{
    Console.WriteLine("Числа равны");    
}