// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
int ReadNumb(string messages)
{
    Console.Write(messages);
    return Convert.ToInt32(Console.ReadLine());
}

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


void GetSearchByIndex(int[,] mas)
{
    int i = ReadNumb("Введите строку: ");
    int j = ReadNumb("Введите столбец: ");
    
    if(i-1<mas.GetLength(0) && j-1<mas.GetLength(1))
    {
        System.Console.WriteLine($"Искомый элемент {mas[i-1,j-1]}");
    }
    else System.Console.WriteLine("Такой позиции нет");
}





const int M = 3;
const int N = 4;

int[,] massiv = GetRandomMatrix(M, N);
PrintArray(massiv);
GetSearchByIndex(massiv);



