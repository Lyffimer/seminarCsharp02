// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
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
void PrintDualArray(int[,]arr)
{
    for (int i=0;i<arr.GetLength(0);++i)
    {
        for (int j=0;j<arr.GetLength(1);++j)
        {
            Console.Write ($"{arr[i,j]} ");
        }
        Console.WriteLine();
    } 
}
void RowsSorting(int[,] array)
{
    int count;
    int temp;
    for (int i=0;i<array.GetLength(0);i++)
    {
        count=array.GetLength(1);
        for (int k=0;k<array.GetLength(1)-1;k++)
        {
            for (int j=0;j<count-1;j++)
            {
                if (array[i,j]>array[i,j+1])
                {
                    temp=array[i,j];
                    array[i,j]=array[i,j+1];
                    array[i,j+1]=temp;
                }
            }
            count--;
        }
    }
}
int [,] newmatrix=GetRandomMatrix(3,4);
PrintDualArray(newmatrix);
RowsSorting(newmatrix);
Console.WriteLine();
PrintDualArray(newmatrix);