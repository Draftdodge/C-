// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).



Console.WriteLine("Введите номер четверти:");
string quarter = Console.ReadLine();

string result = CoordinatesOfQuarter(quarter);

Console.WriteLine(result);

string CoordinatesOfQuarter(string quarterNumber)
{
    if (quarterNumber == "1") return "Координаты x > 0 и у > 0";
    if (quarterNumber == "2") return "Координаты x < 0 и у > 0";
    if (quarterNumber == "3") return "Координаты x < 0 и у < 0";
    if (quarterNumber == "4") return "Координаты x > 0 и у < 0"; 
    return "Введенные данные не корректны";
}