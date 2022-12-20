// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



// int ReadInt(string messages)
// {
//     Console.WriteLine(messages);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int num =ReadInt("Введите число число :");
// System.Console.Write("0 1");
// int a = 0;
// int b = 1;
// int count;
// for (int i=2; i<num;i++)
// {
//     System.Console.Write($" {a+b}");
//     count =b;
//     b=a+b;
//     a=count;
// }



int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}

int num =ReadInt("Введите число :");

int[] fib = new int[num];
fib[0] = 0;
fib[1] = 1;
for(int i = 2; i != num; i++)
{
    fib[i] = fib[i-2] + fib[i-1];
}

Console.WriteLine(string.Join(" ", fib));


