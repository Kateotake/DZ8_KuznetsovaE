
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void PrintArray(int[,,] matr)
{
    for (int col = 0; col < matr.GetLength(2); col++)
    {
        for (int list = 0; list < matr.GetLength(1); list++)
        {
            for (int row = 0; row < matr.GetLength(0); row++)
            {
            Console.Write($"{matr[list, row, col]} ({list},{row} {col}) " );
            }
        Console.WriteLine();
        };
    }
}

int[,,] FillArray(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                array[i, j, k] = new Random().Next(1, 100);
            }
        }
    } 
    return array;
}


int[,,] mas = FillArray(2, 2, 2 );
PrintArray(mas);
