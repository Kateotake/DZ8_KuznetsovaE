// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            array[i, j] = new Random().Next(1, 10);
    }
    return array;
}

int[,] MatrixMult(int[,] matr1, int[,] matr2)
{
    int[,] res = new int[matr2.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int n = 0; n < matr1.GetLength(0); n++)
            {
                res[i, j] += matr1[i, n] * matr2[n, j];
            }
        }
    }
    return res;
}

int[,] mas1 = FillArray(2, 2);
int[,] mas2 = FillArray(2, 1);
if (mas1.GetLength(1) == mas2.GetLength(0)) 
{
    int[,] result = MatrixMult(mas1,mas2);
    PrintArray(mas1);
    Console.WriteLine();
    PrintArray(mas2);
    Console.WriteLine();
    PrintArray(result);
}
else Console.WriteLine ("Некорректный размер матрицы. Число столбцов первой матрицы должно быть равно числу строк второй матрицы");