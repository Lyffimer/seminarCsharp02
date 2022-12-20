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
            mart[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return mart;

}




int M = ReadNumb("Введите количество строк: ");
int N = ReadNumb("Введите количество столбцов: ");

int[,] massiv = GetRandomMatrix(M, N);
// FillingRand(massiv);
PrintArray(massiv);
//System.Console.WriteLine(string.Join(", ", massiv));
