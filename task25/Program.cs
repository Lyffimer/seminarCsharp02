// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int degreeOfNumber(int basis, int exponent)
{
    int result = 1;
    for(int i = 1; i <= exponent; i++)
    {
        result = result * basis;
    }
    return result;
}
int A = ReadInt("Введите основание степени: ");
int B = ReadInt("Введите показатель степени: ");
int res = degreeOfNumber(A, B);
Console.WriteLine($"Число {A} в степени {B} равно {res}");



// basis основание
// exponent показатель
// degree стпень




