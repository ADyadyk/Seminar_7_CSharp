/*
Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

позиция i = 4, j = 2 -> такой позиции нет
позиция i = 1, j = 0 -> 5
*/

// Создание массива
int[,] GetArray()
{
    Console.Write("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine()!);

    Console.Write("Введите минимальное значение элемента: ");
    int minValue = int.Parse(Console.ReadLine()!);

    Console.Write("Введите максимальное значение элемента: ");
    int maxValue = int.Parse(Console.ReadLine()!);

    int[,] res = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            res[i,j] = new Random().Next(minValue, maxValue + 1);
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

//Метод поиска элемента по адресу:

void GivePoz(int[,] arr, int n, int m)
{
    

    if ((n >= arr.GetLength(0)) || (m >= arr.GetLength(1))) Console.Write("Такой позиции нет!");
    else Console.Write($"Элемент равен {arr[n,m]}");
}



//Сама программа
int[,] mas = GetArray();
PrintArray(mas);

Console.Write("Введите номер строки в которой находится элемент (начиная с 0): ");
int i = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер столбца в которой находится элемент (начиная с 0): ");
int j = int.Parse(Console.ReadLine()!);

GivePoz(mas, i, j);