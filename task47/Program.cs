// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



double[,] GetRandomDoubleMatrix(int rows, int columns, double leftRange = -9.9,  double rightRange = 9.9)
{
    double[,] mart = new double[rows, columns];
    var rand = new Random();
    for(int i = 0; i < mart.GetLength(0); i++)
    {
        for(int j = 0; j< mart.GetLength(1); j++)
        {
            mart[i,j] = leftRange + rand.NextDouble() * (Math.Abs(leftRange) + rightRange);

        }
    }
    return mart;
}

void PrintArray(double[,] arr)
{
    for(int i = 0; i != arr.GetLength(0); i++)
    {
        for(int j = 0; j != arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]:f1}, ");
        }
        System.Console.WriteLine();
    }
}

int ReadNumb(string messages)
{
    Console.Write(messages);
    return Convert.ToInt32(Console.ReadLine());
}


int M = ReadNumb("Введите количество строк: ");
int N = ReadNumb("Введите количество столбцов: ");

double[,] massiv = GetRandomDoubleMatrix(M, N);

PrintArray(massiv);


