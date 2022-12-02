// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10,100);// первое число включается в диапазон, а второе не включается


int digit2 = number % 10;
int digit1 = number / 10;

Console.WriteLine($"Случайное число = {number}, первая цифра = {digit1}, Вторая цифра = {digit2}");

int max = digit1;
if(max < digit2)
{
    max = digit2;
}
Console.WriteLine(max);