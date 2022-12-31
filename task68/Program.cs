// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
int AnN(int m, int n)
{
    if (m==0) return n+1;
    else
    {
        if (m>0 && n==0) return AnN(m-1,1);
        else return AnN(m-1,(AnN(m,n-1)));
    } 
}
int mun= AnN(2,3);
Console.WriteLine(mun);