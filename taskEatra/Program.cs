// Доп. задание
// Написать метод для разворота массива, не используя память под дополнительный массив
// void FillArray(int[] collection) //Метод заполенения
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] col) //Метод вывода масива в строку
// {
//     int count =col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]} ");
//         position++;
//     }
// }

void ReversArray(int[] Rev) //Метод разворота массива
{
    int bust;
    int indexStart = 0;
    int indexEnd = Rev.Length - 1;
    while (indexStart < indexEnd)
    {
        bust = Rev[indexStart];
        Rev[indexStart] = Rev[indexEnd];
        Rev[indexEnd] = bust;
        indexStart++;
        indexEnd--;
    }
}


// int[] array = new int[9];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine(" ");
// ReversArray(array);
// PrintArray(array);
