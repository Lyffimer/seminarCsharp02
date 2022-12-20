// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



int ReadNumb(string messages)
{
    Console.Write(messages);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetFillMatrix(int rows, int columns)
{
    int[,] mart = new int[rows, columns];
    for(int i = 0; i < mart.GetLength(0); i++)
    {
        for(int j = 0; j< mart.GetLength(1); j++)
        {
            mart[i,j] = i + j;
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

int M = ReadNumb("Введите количество строк: ");
int N = ReadNumb("Введите количество столбцов: ");

int[,] massiv = GetFillMatrix(M, N);
PrintArray(massiv);