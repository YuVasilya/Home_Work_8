// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] CreatIt(int x, int y, int z)
{
    return new int[x, y, z];
}

void FillIt(int[,,] massiv)
{
    int x = massiv.GetLength(0);
    int y = massiv.GetLength(1);
    int z = massiv.GetLength(2);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                massiv[i,j,k]=new Random().Next(1,10);
            }
        }
    }
}

void PrintIt(int[,,] massiv)
{
int x = massiv.GetLength(0);
    int y = massiv.GetLength(1);
    int z = massiv.GetLength(2);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Console.Write($" {massiv[i,j,k]}({i} {j} {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] horor = CreatIt(2,2,2);
FillIt(horor);
PrintIt(horor);