// Two-dimensional arrays

Console.WriteLine("Task 46");
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

System.Console.Write("Enter the number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-100, 101);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


System.Console.WriteLine("\nTask 48");
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4

System.Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[rows, columns];

for (int row = 0; row < table.GetLength(0); row++)
{
    for (int column = 0; column < table.GetLength(1); column++)
    {
        table[row, column] = row + column;
        Console.Write(table[row, column] + " ");
    }
    Console.WriteLine();
}


System.Console.WriteLine("\nTask 49");
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// А потом так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

System.Console.Write("Enter the number of rows: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the number of columns: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[rows1, columns1];

Console.WriteLine("Original matrix1:");
for (int row = 0; row < matrix1.GetLength(0); row++)
{
    for (int column = 0; column < matrix1.GetLength(1); column++)
    {
        matrix1[row, column] = new Random().Next(0, 10);
        Console.Write(matrix1[row, column] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Modified matrix1:");
for (int row = 0; row < matrix1.GetLength(0); row++)
{
    for (int column = 0; column < matrix1.GetLength(1); column++)
    {
        if ((row+1)%2==0 && (column+1)%2==0)
        {
            matrix1[row, column] = matrix1[row, column] * matrix1[row, column];
        }
        Console.Write(matrix1[row, column] + " ");
    }
    Console.WriteLine();
}