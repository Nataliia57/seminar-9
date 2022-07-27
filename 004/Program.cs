// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, 
//кратные трём.

int m =1;
int n = 21;
Recursion(m, n);
Console.WriteLine();

void Recursion(int m, int n)
{
    if (m >= n) return;
    if (m%3 == 0)
    {
       Console.Write(m + " "); 
    }
    m++;
    Recursion(m, n);
}

