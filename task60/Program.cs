// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
int[,,] NewTripleArray(int rows,int columns,int height)
{
    int[,,] array=new int[rows,columns,height];
    int rand =10;
    for (int i=0;i<rows;++i)
    {
        for (int j=0;j<columns;++j)
        {
            for (int k=0;k<height;++k)
            {
                array[i,j,k]=rand;
                rand++;
            }
        }
    }  
    return array;
}
void PrintTripleArray(int[,,]arr)
{
    for (int i=0;i<arr.GetLength(0);++i)
    {
        for (int j=0;j<arr.GetLength(1);++j)
        {
            for (int k=0;k<arr.GetLength(2);++k)
            {
                Console.WriteLine ($"[{i},{j},{k}]{arr[i,j,k]} ");
            }
        }
    } 
}
int [,,] newkub=NewTripleArray(2,2,2);
PrintTripleArray(newkub);