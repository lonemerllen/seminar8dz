// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] a = new int[3, 4]
{{1,3,5,6},
 {5,7,9,2},
 {4,6,3,8}};
 int temp;
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int n=0;n<a.GetLength(1);n++){   
        for (int j = 0; j < a.GetLength(1)-1; j++)
        {
            if (a[i,j]<a[i,j+1])
            {
                temp = a[i,j];
                a[i,j]=a[i,j+1];
                a[i,j+1]=temp;
            }
        }
    }
}
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write($"{a[i,j]} ");
    }
Console.WriteLine();
}