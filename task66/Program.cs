// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int printnum(int n, int m)
{
    if (n==m) return n;
    else
    {
        return n+printnum(n+1, m);
    }
}
Console.WriteLine(printnum(1, 15));