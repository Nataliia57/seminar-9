// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = 1;
int n = 15;
Recursion(m, n);
Console.WriteLine();

void Recursion(int m, int n, int summa = 0)
{
    if (m > n)
    {
        Console.Write(summa + " ");
        return;
    }
        summa = summa + m;
        m++;
    Recursion(m, n, summa);
}

