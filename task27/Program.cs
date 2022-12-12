// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumOfNumber(int number)
{
    int sum = 0;
    for(int i = number; i != 0; i/=10)
    {
        sum = sum + i%10;
    }
    return sum;
}

int N = ReadInt("Введите число: ");
int result = GetSumOfNumber(N);
Console.WriteLine($"Сумма цифр в числе {N} равна {result}");


