// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Программа для нахождения точки пересечения двух прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
Console.Write("Введите значение k1 и нажмите Enter: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1 и нажмите Enter: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2 и нажмите Enter: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2 и нажмите Enter: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] crossPoint = CrossPoint(k1, b1, k2, b2);
Console.Write("Точка пересечения прямых: ");
PrintArray(crossPoint);

double[] CrossPoint(double k1f, double b1f, double k2f, double b2f)
{
    double[] result = new double[2];
    double x = (b2f - b1f) / (k1f - k2f);
    double y = k1f * x + b1f;
    result[0] = Math.Round(x, 1);
    result[1] = Math.Round(y, 1);
    return result;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}