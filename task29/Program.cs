// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем
int[] arr = new int[8];
void ManualFilliArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i] =  Convert.ToInt32(Console.ReadLine());
    }
}
// void ManualFilliArray(int[] array)// Эксперементальное решение, нет ограничения на кол во элементов
// {
//     Console.Write("Введите через пробел 8 элементов массива: ");
//     string[] arrString = Console.ReadLine().Split(" ");
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(arrString[i]);
//     }
// }
ManualFilliArray(arr);
Console.WriteLine(string.Join(", ", arr));
