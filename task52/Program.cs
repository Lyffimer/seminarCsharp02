// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int ReadNumb(string messages)
// {
//     Console.Write(messages);
//     return Convert.ToInt32(Console.ReadLine());
// }

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] mart = new int[rows, columns];

    var rand = new Random();
    for(int i = 0; i < mart.GetLength(0); i++)
    {
        for(int j = 0; j< mart.GetLength(1); j++)
        {
            mart[i,j] = rand.Next(leftRange, rightRange);
        }
    }

    return mart;

}

void PrintArray(int[,] arr)
{
    for(int i = 0; i != arr.GetLength(0); i++)
    {
        for(int j = 0; j != arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]}, ");
        }
        System.Console.WriteLine();
    }
}

// Метод возвращяет значение переменной double по заданному столбцу заданного массива,
// но нет вменяемой проверки на наличие заданного столбца, можно ее поставить и возвращать значение 0 в случае срабатывания
// но это както так себе

// double AverageColumn(int[,] arr, int column)
// {
//     double average = 0;
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         average = average + arr[i,column-1];
//     }
//     average = average/arr.GetLength(0);
//     return average;
// }

const int M = 3;// или ReadNumb("Введите количество строк: ")
const int N = 4;// или ReadNumb("Введите количество столбцов: ")
// int columns = 1;// или ReadNumb("Введите номер столбца: ")
int[,] massiv = GetRandomMatrix(M, N);
PrintArray(massiv);
// double st1 = AverageColumn(massiv, columns);
// System.Console.WriteLine($"Среднее арифметическое столбца {columns} =  {st1:f2}");


// метод который переберет все столбцы и выведет среднее арифметическое каждоко в терминал
void GetAverageColumn(int[,] arr) 
{
    for(int i = 0; i != arr.GetLength(1); i++)
    {
        double average = 0;
        int j = 0;
        for(; j != arr.GetLength(0); j++)
        {
            average = average + arr[j,i];
        }
        System.Console.WriteLine($"Среднее арифметическое столбца {i+1} = {(average/arr.GetLength(0)):f2}");
    }
}
GetAverageColumn(massiv);

