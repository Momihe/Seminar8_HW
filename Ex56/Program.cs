/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7
*/

void FillMatirx(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}

int StringSum(int[,] matrix, int n)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[n, j];
    }
    return sum;
}

void FunSumChek(int[,] matrix, int[] MassSumChek)
{
    for (int n = 0; n < MassSumChek.Length; n++)
    {
        MassSumChek[n] = StringSum(matrix, n);
        Console.WriteLine($"Сумма строки {n + 1} равна {MassSumChek[n]}.");
    }
    int min = MassSumChek[0];
    int IndexMin = 0;
    for (int n = 0; n < MassSumChek.Length; n++)
    {
        if (MassSumChek[n] < min)
        {
            min = MassSumChek[n];
            IndexMin = n;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с минимальными суммами  -  {IndexMin + 1}");
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] MassSumChek = new int[size[0]];
FillMatirx(matrix);
PrintMatrix(matrix);
FunSumChek(matrix, MassSumChek);