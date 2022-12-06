// Задача 20: Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите кординату Х первого числа ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Х первого числа ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Х первого числа ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Х первого числа ");
int y2 = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(x2 - x1 , 2) + Math.Pow(y2 - y1 , 2));
Console.Write($"Итог: {res:f2}");



// int a = 25;
// int b = 2;
// double resSqrt = Math.Sqrt(a);
// double resPow = Math.Pow(a, b);

// Console.WriteLine($"{resSqrt:f2}");
// Console.WriteLine(resPow);
