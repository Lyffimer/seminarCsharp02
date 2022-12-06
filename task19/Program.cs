// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int NClone = 0;
for(int arg = N; arg > 0; arg = arg / 10)
{
    NClone = (NClone * 10) + (arg % 10);
}
//Console.WriteLine($"{N},{NClone}");//Выыод исходного числа и перевернутого
if(N == NClone)
{
    Console.WriteLine("Число полиндром");
}
else Console.WriteLine("Число не полиндром");