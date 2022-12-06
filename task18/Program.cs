// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти = ");
int room = Convert.ToInt32(Console.ReadLine());

if(room > 4 || room < 1) Console.WriteLine("Нет такой четверти");
else if(room == 1) Console.WriteLine("x > 0; y > 0");
else if(room == 2) Console.WriteLine("x < 0; y > 0");
else if(room == 3) Console.WriteLine("x < 0; y < 0");
else if(room == 4) Console.WriteLine("x > 0; y < 0");