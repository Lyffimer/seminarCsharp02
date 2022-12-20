// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] array = {1, 2, 3, 4, 5};
int[] array2 = new int[array.Length];
for(int i = 0; i != array.Length; i++)
{
    array2[i] = array[i];
}

System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine(string.Join(", ", array2));