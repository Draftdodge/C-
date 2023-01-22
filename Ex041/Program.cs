// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


double[] FillArrayDouble(int lengthArr)
{
    double[] arr = new double[lengthArr];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} число и нажмите Enter  ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int SearchPositivNumber(double[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result++;
    }

    return result;
}


Console.Write("Введите колличество чисел, которое будете вводить: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayDouble(lengthArray);
int positivNumber = SearchPositivNumber(array);
Console.Write("Введены числа: ");
PrintArray(array);
if (positivNumber == 0 || positivNumber >= 5) Console.WriteLine($"Среди введенных чисел больше 0 - {positivNumber} чисел.");
if (positivNumber == 1) Console.WriteLine($"Среди введенных чисел больше 0 - {positivNumber} число.");
if (positivNumber >= 2 && positivNumber <= 4) Console.WriteLine($"Среди введенных чисел больше 0 - {positivNumber} числа.");