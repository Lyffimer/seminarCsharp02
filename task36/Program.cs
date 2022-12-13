// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int length)
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-99, 100);
    }
    return array;
}

int SumOddIndex(int[] array)
{
    int SUM = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        SUM=SUM+array[i];
    }
    return SUM;
}

const int LENGTH = 4;

int[] massif = GetRandomArray(LENGTH);
System.Console.WriteLine(string.Join(", ", massif));
int sum = SumOddIndex(massif);
System.Console.WriteLine($"Сумма нечетных элементов равна {sum}");