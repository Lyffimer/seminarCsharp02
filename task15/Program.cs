// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    if(number == 6 || number == 7)
    {
        Console.Write("Это выходной!");
    }
    else Console.Write("Это будний день");
}
else Console.Write("Нет такого дня недели");

