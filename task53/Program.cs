// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.
int[,] NewDualArray(int rows,int columns, int leftRange = 0,int rightRange = 10)
{
    int[,] array=new int[rows,columns];
    Random rand = new Random();
    for (int i=0;i<rows;++i)
    {
        for (int j=0;j<columns;++j)
        {
            array[i,j]=rand.Next(leftRange,rightRange);
        }
    }  
    return array;
}
void PrintDualArray(int[,]arr)
{
    for (int i=0;i<arr.GetLength(0);++i)
    {
        for (int j=0;j<arr.GetLength(1);++j)
        {
            Console.Write ($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    } 
}
void Chengerows(int[,]arr)
{
    int temp=0;
    for (int j=0;j<arr.GetLength(1);++j)
    {
        temp=arr[0,j];
        arr[0,j]=arr[arr.GetLength(0)-1,j];
        arr[arr.GetLength(0)-1,j]=temp;
    } 
}
int [,] matrix=NewDualArray(3,4);
PrintDualArray(matrix);
Console.WriteLine();
Chengerows(matrix);
PrintDualArray(matrix);