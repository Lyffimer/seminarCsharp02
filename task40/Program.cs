// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
//треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.WriteLine("Введите длинны сторон: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());

if(A < B+C && B < A+C && C < A+B)
{
    Console.WriteLine("Такой треугольник существует!");
}
else System.Console.WriteLine("Такого треугольника не может быть!");





