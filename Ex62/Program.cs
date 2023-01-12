/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void SpiralFillMatrix(int[,] matrix, int i, int j, int k, int l)
{
    if ((matrix[i, j] == 0) && (k < l + 1))
    {
        matrix[i, j] = k;
        if ((k > ((matrix.GetLength(1) + (matrix.GetLength(0) - 1) + (matrix.GetLength(1) - 1)))) //это что бы на с третьего на четвертый поворот спирали нормально работало
        && (matrix[i, j + 1] == 0) 
        && ((matrix[i + 1, j + 1] != 0) || (matrix[i - 1, j]) == 0)
        && (matrix[i - 1, j] == 0))
        SpiralFillMatrix(matrix, i - 1, j, k + 1, l);

        if ((j < matrix.GetLength(1) - 1) && (matrix[i, j + 1] == 0)) SpiralFillMatrix(matrix, i, j + 1, k + 1, l);      

        if ((i < matrix.GetLength(0) - 1) && (matrix[i + 1, j] == 0)) SpiralFillMatrix(matrix, i + 1, j, k + 1, l);
        
        if ((j >= 1) && (matrix[i, j - 1] == 0)) SpiralFillMatrix(matrix, i, j - 1, k + 1, l);
        
        if ((i >= 1) && (matrix[i - 1, j] == 0)) SpiralFillMatrix(matrix, i - 1, j, k + 1, l);
        
    }
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
int i = 0;
int j = 0;
int l = size[0] * size[1];
int k = 1;
SpiralFillMatrix(matrix, i, j, k, l);
PrintMatrix(matrix);
Console.Write($"Последний элемент равен: {l}.");