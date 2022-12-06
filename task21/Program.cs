// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите кординату Х первого числа ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Y первого числа ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Z первого числа ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату X второго числа ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Y второго числа ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Z второго числа ");
int z2 = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(x2 - x1 , 2) + Math.Pow(y2 - y1 , 2) + Math.Pow(z2 - z1 , 2));
Console.Write($"Итог: {res:f2}");