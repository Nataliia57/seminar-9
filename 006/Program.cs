// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = 2;
int n = 2;
Console.WriteLine(Recursion(m, n));

int Recursion(int m, int n)
{
    if (m == 0) return n+1;
    if (n == 0) return Recursion(m - 1, 1);
    return Recursion(m - 1, Recursion(m, n- 1));
    
}
