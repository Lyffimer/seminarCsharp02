// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] multOfElem(int[] array)
{
    int[] col = new int[array.Length/2 + array.Length%2];
    
    int[] col; 
    if(array.Length % 2 == 0)
    {
        col = new int[array.Length/2];
    }
    else
    {
        col = new int[array.Length/2 + 1];
        col[col.Length/2 + 1] = array[array.Length/2 ];
    }
    for(int i = 0; i < array.Length/2; i++)
    {
        col[i] = array[i] * array[array.Length - 1 - i];
    }
    return col;
}


int[] res = {6,7,3,6};
Console.WriteLine(string.Join(", ", res));
int[] res2 = multOfElem(res);
Console.WriteLine(string.Join(", ", res2));