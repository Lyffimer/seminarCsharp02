// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// string A = "";
// A = +"0";
// A = +"12";
// System.Console.WriteLine(A);




// int ReadInt(string messages)
// {
//     Console.WriteLine(messages);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int num = ReadInt("Введите число число :");
// int numd = num;
// int i = 1;
// for (; numd != 0; i++)
// {
//     numd = numd / 2;
// }
// int[] arr = new int[i];
// for (; num != 0; i--)
// {
//     arr[i - 1] = num % 2;
//     num = num / 2;

// }
// Console.WriteLine(string.Join("", arr));

int number = 45;


void PrintBinaryView(int n)
{
    if (n <= 0) return;
    PrintBinaryView(n / 2);
    Console.Write(n % 2);
}

PrintBinaryView(number);
