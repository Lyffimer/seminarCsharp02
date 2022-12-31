// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


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
        Console.WriteLine();
    } 
}
int[,]ArrayMultiplication(int[,] arr1, int[,]arr2)
{
    int [,]MultiArray =new int[arr1.GetLength(0),arr1.GetLength(1)]; 
    for (int i=0;i<arr1.GetLength(0);i++)
    {
        for (int j=0; j<arr1.GetLength(1);j++)
        {
            MultiArray[i,j]=arr1[i,j]*arr2[i,j];
        }
    }
    return MultiArray;

}
int [,] newmatrix=NewDualArray(3,4);
PrintDualArray(newmatrix);
Console.WriteLine();
int [,] newmatrix2=NewDualArray(3,4);
PrintDualArray(newmatrix2);
Console.WriteLine();

if (newmatrix.GetLength(0)==newmatrix2.GetLength(0) && newmatrix.GetLength(1)==newmatrix2.GetLength(1))
{
    int [,] resmatrix = ArrayMultiplication(newmatrix,newmatrix2);
    PrintDualArray(resmatrix);
}
else
Console.WriteLine("Массивы нельзя сложить");