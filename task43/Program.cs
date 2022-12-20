// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadInt(string messages)
{
    Console.Write(messages);
    return Convert.ToDouble(Console.ReadLine());
}

// Просто ввод и решение
// double Y;
// double X;
// double b1 = ReadInt("Введите b1: ");
// double b2 = ReadInt("Введите b2: ");
// double k1 = ReadInt("Введите k1: ");
// double k2 = ReadInt("Введите k2: ");
// X = -(b1 - b2)/(k1 - k2);
// Y = k2*X +b2;
// System.Console.WriteLine($"Координаты точки пересечения ({X};{Y})");


// Ручной ввод и передача в метод. можно сделать запрос коф из метода, но мне кажется так правильнее
// (double, double) IntersectionSearch(double b1, double k1, double b2, double k2)
// {
//     double x;
//     double y;
//     x = -(b1 - b2)/(k1 - k2);
//     y = k2*x +b2;
//     return (x, y);
// }

// double B1 = ReadInt("Введите b1: ");
// double K1 = ReadInt("Введите k1: ");
// double B2 = ReadInt("Введите b2: ");
// double K2 = ReadInt("Введите k2: ");
// if(K1 == K2)
// {
//     System.Console.WriteLine("Линии паралельны!");
// }
// else
// {
// (double X, double Y) = IntersectionSearch(B1, K1, B2, K2);
// System.Console.WriteLine($"Координаты точки пересечения ({X};{Y})");
// }


double Readdouble(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToDouble(Console.ReadLine());
}
double b1 =Readdouble("Введите коэффициент b1 первой пряммой заданой уравнением y = k1 * x + b1:");
double k1 =Readdouble("Введите коэффициент k1 первой пряммой заданой уравнением y = k1 * x + b1:");
double b2 =Readdouble("Введите коэффициент b2 первой пряммой заданой уравнением y = k2 * x + b2:");
double k2 =Readdouble("Введите коэффициент k2 первой пряммой заданой уравнением y = k2 * x + b2:");
double x;
double y;
if (k1==k2)
{
    Console.WriteLine("Линии с такими коэффициент к1 и к2 не пересикаются.");
}
else 
{
    x=(b2-b1)/(k1-k2);
    y=k1*x+b1;
    Console.WriteLine($"Линии пересекутся в точке с координатами х = {x}, y = {y}.");
}

