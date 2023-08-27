/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

//Метод, который ищет среднее арифметическое элементов в каждом столбце массива:

void Average(int[,] arr)
{
    double rowSum = 0;
    double avrg = 0;

    for (int j=0; j < arr.GetLength(1); j++)
    {
        for(int i=0; i < arr.GetLength(0); i++)
        {
            rowSum += Convert.ToDouble(arr[i,j]);
        }
        Console.Write($"Столбец с индексом {j}");
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов столбца равна:{rowSum}");
        Console.WriteLine($"Количество элементов в столбце равно {arr.GetLength(0)}");
        avrg = Math.Round((rowSum / arr.GetLength(0)), 2);
        Console.WriteLine($"Среднее арифметическое столбца равно: {avrg}");
        Console.WriteLine();
        rowSum = 0;
    }
}


//Сама программа
int[,] mas = GetArray();
PrintArray(mas);
Average(mas);