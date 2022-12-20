// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной

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

int ChengArray(int[,] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.GetLength(0) && i < arr.GetLength(1); i++)
    {
        sum = sum + arr[i,i];
        
    }
    return sum;
}

int M = ReadNumb("Введите количество строк: ");
int N = ReadNumb("Введите количество столбцов: ");

int[,] massiv = GetRandomMatrix(M, N);
PrintArray(massiv);
int res = ChengArray(massiv);
System.Console.WriteLine($"Сумма элементов по диагонали {res}");
