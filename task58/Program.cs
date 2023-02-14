// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] a = new int[2,2]
{{2,4},
 {3,2}};
int[,] b = new int[2,2]
{{3,4},
 {3,3}};
int[,] r = new int[a.GetLength(0),b.GetLength(1)];
for (int i =0;i<a.GetLength(0);i++)
{
    for (int j = 0;j<b.GetLength(1);j++)
    {
        for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i,j] += a[i,k] * b[k,j];
            }
    }

}
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write($"{r[i,j]} ");
    }
Console.WriteLine();
}