// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetRandomArray(int length)
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 151);
    }

    return array;
}

int NumberOfValuesInTheRange(int[] array, int rangeStart, int rangeEnd)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > rangeStart && array[i] < rangeEnd)
        {
            count++;
        }
    }
    return count;
}

const int LENGTH = 123;
const int rangeDown = 10;
const int rangeTop = 99;

int[] massif = GetRandomArray(LENGTH);
Console.WriteLine(string.Join(", ", massif));
int numb = NumberOfValuesInTheRange(massif, rangeDown, rangeTop);
Console.WriteLine($"В диапазоне от {rangeDown} до {rangeTop} находится {numb} чисел");