// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
int[,] NewDualSpiralArray(int rows,int columns)
{
    int[,] array=new int[rows,columns];
    int i=0;
    int j=-1;
    int k=1;
    int num=0;
    while (num<array.GetLength(0)*array.GetLength(1))
    {
        for (int n=0;n<columns;n++)
        {
            num++;
            j=j+1*k;
            if (j>=0)
            array[i,j]=num;
            
        }
        columns--;
        for (int n=0;n<rows-1;n++)
        {
            num++;
            i=i+1*k;
            array[i,j]=num;

        }
        k=k*-1;
        rows--;

    }
    return array;
}
void PrintDualArray(int[,]arr)
{
    for (int i=0;i<arr.GetLength(0);++i)
    {
        Console.Write("[");
        for (int j=0;j<arr.GetLength(1);++j)
        {
            Console.Write ($"{arr[i,j]} ");
        }
        Console.WriteLine("]");
    } 
}
int [,] newmatrix=NewDualSpiralArray(4,4);
PrintDualArray(newmatrix);