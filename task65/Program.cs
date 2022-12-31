// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
void printnum(int n, int m)
{
    int k;
    if (n<m) k=-1;
    else k=1;
    if (n==m) Console.Write($"{m}");
    else
    {
        Console.Write($"{n},");
        printnum((n-1*k),m);
    }
}
printnum( 2,5 );
