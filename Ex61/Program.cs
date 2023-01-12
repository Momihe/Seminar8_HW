/*
Задача 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.
*/
void PascaleTriangle(int[,] matrix, int size)
{
    if (size == 1) matrix[0, 0] = 1;
    else
    {
        matrix[0, (matrix.GetLength(1) / 2)] = 1;
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = (matrix.GetLength(1) / 2) - i; j < (matrix.GetLength(1) / 2 + 1 + i); j += 2)
            {
                if ((j == 0) || (j == (matrix.GetLength(1) - 1))) matrix[i, j] = 1;
                else
                {
                    matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
                }
            }
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) Console.Write($"_");
            else 
            Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
void PrintMatrix2(int[,] matrix)
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
Console.Write("Количество строк треугольника: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[size, (size * 2 - 1)];
string[,] matrix2 = new string[size, (size * 2 - 1)];
PascaleTriangle(matrix, size);
PrintMatrix(matrix);
Console.WriteLine("---------------------------------------------");
Console.WriteLine("Или так.");
Console.WriteLine("---------------------------------------------");
PrintMatrix2(matrix);