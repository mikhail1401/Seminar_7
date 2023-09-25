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