// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите координаты точки A:");
Console.WriteLine("Введите X:");
double xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
double yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
Console.WriteLine("Введите X:");
double xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
double yB = Convert.ToInt32(Console.ReadLine());


result = Math.Round(Distance(xA, yA, xB, yB), 2, MidpointRounding.ToZero);

Console.WriteLine(result);

double Distance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return distance;
}

// double d = Math.Sqrt(25); 
// // Math.Pow (2, 2)
// double numD = 5.0997823232;
// double numRound = Math.Round(numD, 2, MidpointRounding.ToZero);
// Console.WriteLine(numRound);
