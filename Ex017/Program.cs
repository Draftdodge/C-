// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.


Console.WriteLine("Введите X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = NumberOfQuarter(x, y);

string result = quarter>0 ? 
                    $"указаные координаты соответствуют четверти -> {quarter}"
                    : "Введены некоректные координаты";
Console.WriteLine(result);

int NumberOfQuarter(int xc, int yc)
{
    if (xc>0 && yc>0) return 1;
    if (xc<0 && yc>0) return 2;
    if (xc<0 && yc<0) return 3;
    if (xc>0 && yc<0) return 4; 
    return 0;
}