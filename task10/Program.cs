// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    int remainder = ((number/10) % 10);
    Console.Write($"Вторая цифра {remainder}");
}
else Console.Write($"Число не трехзначное");
