/*
**Задача 48:** Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: A(i,j) = i+j.
 Выведите полученный массив на экран.

m = 3, n = 4.

0 1 2 3

1 2 3 4

2 3 4 5

*/

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);


Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

PrintArray(GetArray(rows, columns));


// Создание массива
int[,] GetArray(int m, int n)
{
    int[,] res = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            res[i,j] = i + j;
        }
    }
    return res;
}

// Печать массива
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}