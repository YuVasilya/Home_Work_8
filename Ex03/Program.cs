// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] Creat3d(int x, int y, int z)
{
    return new int[x, y, z];
}

void Fill3d(int[,,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);
    int startnumber = 10;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array[i,j,k] = startnumber + 5;
            }
        }
    }
}

void Print3d(int[,,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Console.Write($" {array[i, j, k]}({i} {j} {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] twodigit = Creat3d(2, 2, 2);

Fill3d(twodigit);

Print3d(twodigit);

