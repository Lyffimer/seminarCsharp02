// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArrayThreeDigits(int length)//СОздание массива трехзначных элементов
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
    }

    return array;
}

int EvenNumberCounter(int[] array)//Счетчик четных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.Write("Введите колличество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] massif = GetRandomArrayThreeDigits(length);
Console.WriteLine(string.Join(", ", massif));
int odd = EvenNumberCounter(massif);
System.Console.WriteLine($"В массиве {odd} четных чисел");