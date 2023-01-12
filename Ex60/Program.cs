/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
void FillMatirx(int[,,] matrix)
{   
    int num = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
             {  
                matrix[i, j, k] = num;
                num ++;
             }
        }
    }
}



void PrintMatrix(int[,,] matrix)
{   
    int n = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
             {
                Console.WriteLine($"{n}-й элемент: {matrix[i, j, k]} [{i},{j},{k}]");
                n++;
             }
        }
    }
}



Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int x = (size[0]*size[1]*size[2]);
while ((x >= 100 ) || (x < 1))
{
    Console.Write("Введите корректные размеры матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    x = (size[0]*size[1]*size[2]);
}
int[,,] matrix = new int[size[0], size[1], size[2]];

FillMatirx(matrix);
PrintMatrix(matrix);
