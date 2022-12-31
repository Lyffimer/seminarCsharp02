// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// int ReadNumb(string messages)
// {
//     Console.Write(messages);
//     return Convert.ToInt32(Console.ReadLine());
// } 

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
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

// (int,int) minArray(int[,]arr)
// {
//     int mini=0;
//     int minj=0;
//     for (int i=0;i<arr.GetLength(0);i++)
//     {
//         for (int j=0;j<arr.GetLength(1);j++)
//         {
//             if (arr[mini,minj]>arr[i,j])
//             {
//                 mini=i;
//                 minj=j;
//             }
//         }
//     }
//     return (mini,minj); 
// }
int[,] Chengerowscolums(int[,]arr)
{
    int mini=0;
    int minj=0;
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            if (arr[mini,minj]>arr[i,j])
            {
                mini=i;
                minj=j;
            }
        }
    }
    Console.WriteLine ($"{mini},{minj} ");
    int[,] array=new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    int k1=0;
    int k2=0;
    for (int i=0;i<arr.GetLength(0)-1;i++)
    {
         if (i==mini)
            {
                k1++;
            }
        for (int j=0;j<arr.GetLength(1)-1;j++)
        {
            if (j==minj)
            {
                k2++;
            }
            array[i,j]=arr[i+k1,j+k2];
        }
        k2=0;
    }
    return array; 
}
int [,] matrix=GetRandomMatrix(4,4);
PrintArray(matrix);
int [,]matrix2 =Chengerowscolums(matrix);
PrintArray(matrix2);








