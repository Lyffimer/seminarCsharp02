// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// Считывает целое число от пользователя
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumToNumber(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
        //sum = sum + i;
    }
    return sum;
}

int A = ReadInt("Введите число: ");
int result = GetSumToNumber(A);
Console.WriteLine($"Сумма числел от 1 до {A} = {result}");

