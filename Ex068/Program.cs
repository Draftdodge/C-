// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 3;
int n = 2;

Console.WriteLine(FunctionAkkerman(m, n));

int FunctionAkkerman(int n,int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return FunctionAkkerman(n - 1, 1);
    return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
}