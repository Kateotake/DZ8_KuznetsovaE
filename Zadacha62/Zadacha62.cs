// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int[,] FillSpiralArray(int m, int l)
{
    int[,] a = new int[m, l];

    int row = m - 1;
    int col = l - 1;
    int n = 0;
    int i = 0;
    int j = 0;
    int k = 1;

    while (n != m * l)
    {
        for (j = n; j <= col - n; j++)
        {
            i = n;
            a[i, j] = k;
            k++;
        }
        for (i = n + 1; i <= row - n; i++)
        {
            j = col - n;
            a[i, j] = k;
            k++;
        }
        for (j = col - n - 1; j >= n; j--)
        {
            i = row - n;
            a[i, j] = k;
            k++;
        }
        for (i = row - n - 1; i >= n + 1; i--)
        {
            j = n;
            a[i, j] = k;
            k++;
        }
        n++;
    } 
    return a;
}

int[,] mas = FillSpiralArray(7, 7);
PrintArray(mas);