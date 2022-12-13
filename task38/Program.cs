// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetRandomArray(int length)
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 100);
    }
    return array;
}

int QuotientMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max<array[i])
        {
            max = array[i];
        }
        else if(min>array[i])
        {
            min = array[i];
        }
    }
    int quotient = max - min;
    return quotient;
}


const int LENGTH = 5;

int[] massif = GetRandomArray(LENGTH);
System.Console.WriteLine(string.Join(", ", massif));
int res = QuotientMaxMin(massif);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива {res}");

