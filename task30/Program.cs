// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] array)
{
    int index = 0;
    while(index != array.Length)
    {
        array[index] = new Random().Next(0,2);
        index++;
    }
}

// void PrintArray(int[] count)
// {
//     int col = 0;
//     for(; col != count.Length - 1; col++)
//     {
//         Console.Write($"{count[col]},");
//     }
// }


int[] binar = new int[8];
FillArray(binar);
// PrintArray(binar);
Console.WriteLine(string.Join(",", binar));//метод string.Join("a",b) выводит все элементы массива в строку разделяя их тем что указывается в кавычках


