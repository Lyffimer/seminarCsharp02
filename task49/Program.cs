// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// ​ (в примере подсчет индексов начинается с 1 , как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

void ChengArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i+=2)
    {
        for(int j = 0; j < arr.GetLength(1); j+=2)
        {
            
            arr[i,j] = arr[i,j] * arr[i,j];
        }
        
    }
}

int M = ReadNumb("Введите количество строк: ");
int N = ReadNumb("Введите количество столбцов: ");

int[,] massiv = GetRandomMatrix(M, N);
PrintArray(massiv);
System.Console.WriteLine();
ChengArray(massiv);
PrintArray(massiv);
