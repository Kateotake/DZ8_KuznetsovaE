// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(1, 100);
    }
    return array;
}

int[,] SortArrayRow(int[,] matr)
{
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] < matr[i, k])
                {
                    min = matr[i, k];
                    matr[i, k] = matr[i, j];
                    matr[i, j] = min;
                }
            }
        }
    }
    return matr;
}

int[,] mas = FillArray(3, 4);
PrintArray(mas);
Console.WriteLine();
Console.WriteLine("Массив с отсортированными строками:");
PrintArray(SortArrayRow(mas));
