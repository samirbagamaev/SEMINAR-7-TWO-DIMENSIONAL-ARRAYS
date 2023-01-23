// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int [,] matrix = new int[rows, columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
const int ROWS = 3; // 3 СТРОКИ
const int COLUMNS = 4; // 4 СТОЛБЦА
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
 PrintMatrix(array);