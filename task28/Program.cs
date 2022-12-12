// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int productNumbers(int number)
{
    int res = 1;
    for (int i = 1; i <= number; i++)
    {
        res *= i;
        //sum = sum + i;
    }
    return res;
}

int A = ReadInt("Введите число: ");
int result = productNumbers(A);
Console.WriteLine($"Произвдение чисел от 1 до {A} равно {result}");

