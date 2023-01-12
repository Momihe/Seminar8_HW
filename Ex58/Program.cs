/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


void FillMatirx(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}

void SimpleMultiplication(int[,] matrix1, int[,] matrix2, int[,] matrix)
{   

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
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
//тут как в семинаре, где просто умножение =) . c(i,j) = a(i,j) * b(i,j)  
Console.Clear();
Console.Write("Введите размеры матрицы первой матрицы: ");

int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];

Console.Write("Введите размеры матрицы второй матрицы: ");

int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while ((size1[0] != size2[0]) || (size1[1] != size2[1]))
{
    Console.WriteLine();
    Console.WriteLine("Размеры матриц один и два должны быть равны.");
    Console.Write("Введите размеры второй матрицы: ");
    size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix2 = new int[size2[0], size2[1]];
int[,] matrix = new int[size2[0], size2[1]];

FillMatirx(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
FillMatirx(matrix2);
PrintMatrix(matrix2);
SimpleMultiplication(matrix1, matrix2, matrix);
Console.WriteLine();
PrintMatrix(matrix);