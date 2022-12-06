// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Ведите Х = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y = ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой кординатной четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится в второй кординатной четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей кординатной четверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой кординатной четверти");
}