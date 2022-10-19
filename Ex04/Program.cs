// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

Console.Clear();

int[,] CreatMatrix(int row, int column)
{
    return new int[row, column];
}

void FillMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    int startnumber = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = startnumber ++;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreatMatrix(4, 4);
FillMatrix(matrix);
PrintMatrix(matrix);
