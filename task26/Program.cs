// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int digitСounter(int number)
{
    int i = 0;
    for(; number != 0; number /= 10,i++);
    return i;
}

int A = ReadInt("Введите число: ");
int result = digitСounter(A);
Console.WriteLine($"Количество цифр в числе {A} равно {result}");

