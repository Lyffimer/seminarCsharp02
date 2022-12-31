// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

// void FrequentMethod(int[,]arr, int leftReng = 0, int rightRange = 9)
// {
//     for(int D = leftReng; D <= rightRange; D++ )
//     {
//         int count = 0;
//         for(int i = 0; i != arr.GetLength(0); i++)
//         {
//             for(int j = 0; j != arr.GetLength(1); j++)
//             {
//                 if(arr[i,j] == D)
//                 {
//                     count++;
//                 }
//             }
//             //System.Console.WriteLine();
//         }
//         if(count!=0)
//         {
//             System.Console.WriteLine($"Число {D} встречается {count} раз");
//         }
//     }    
// }




void PritRepit(int[,] matr)
{
    int[] counters = new int[10];
    for(int i = 0; i != matr.GetLength(0); i++)
    {
        for(int j = 0; j != matr.GetLength(1); j++)
        {
            counters[matr[i,j]]++; 
        }
        System.Console.WriteLine();
    }
    for(int i = 0; i <counters.Length; i++)
    {
        if(counters[i]>0)
        {
            System.Console.WriteLine($"Элемент {i} повторяется {counters[i]} раз");
        }
    }
}




int M = ReadNumb("Введите количество строк: ");
int N = ReadNumb("Введите количество столбцов: ");

int[,] massiv = GetRandomMatrix(M, N);
PrintArray(massiv);
// FrequentMethod(massiv);


PritRepit(massiv);
