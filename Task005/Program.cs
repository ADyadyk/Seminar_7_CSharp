/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

//Метод для создания массива заполненного случаными вещественными числами:

double[,] GetArray()
{
    Console.Write("Введите количество строк массива: ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество строк массива: ");
    int n = int.Parse(Console.ReadLine()!);

    Console.Write("Введите минимальное число массива: ");
    int x = int.Parse(Console.ReadLine()!);

    Console.Write("Введите максимальное число массива: ");
    int y = int.Parse(Console.ReadLine()!);

    double[,] res = new double[m,n];

    for (int i=0; i < m; i++)
    {
        for (int j=0; j < n; j++)
        {
            double k = new Random().NextDouble();
            int l = new Random().Next(x, y);
            res[i,j] = Math.Round(l - k, 1);
        }
    }
    return res;
}

//Метод печатающий двумерный массив:

void PrintArray2(double[,] arr)
{
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

//Сама программа:

PrintArray2(GetArray());