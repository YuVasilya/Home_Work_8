// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] CreatMatrix(int row, int col)
{
    return new int[row, col];
}

void FillMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ProductMatrix(int[,] multiplier1, int multiplier2, int[,] product)
{
    int row1 = multiplier1.GetLength(0);
    int col1 = multiplier1.GetLength(1);
    int row2 = multiplier2.GetLength(0);
    int col2 = multiplier2.GetLength(1);

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            for (int m = 0; m < row2; m++)
            {
                for (int n = 0; n < col2; n++)
                {
                    product[k,l] = multiplier1[i,j]*multiplier2[m,n]
                }
            }
        }
    }
}