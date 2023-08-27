/*
**Задача 51:** Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

Сумма элементов главной диагонали: 1+9+2 = 12
*/


// Создание массива
int[,] GetArray()
{
    Console.Write("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов массива: ");
    int n = int.Parse(Console.ReadLine()!);

    Console.Write("Введите максимальное значение элемента: ");
    int maxValue = int.Parse(Console.ReadLine()!);

    Console.Write("Введите минимальное значение элемента: ");
    int minValue = int.Parse(Console.ReadLine()!);

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
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

//Метод определяющий сумму элементов на главной диагонали
void DiagonalSum(int[,] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            if (i==j) sum += arr[i,j];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов на главной диагонали равна: {sum}");
}

//Сама программа:
int[,] array = GetArray();
PrintArray(array);
DiagonalSum(array);
