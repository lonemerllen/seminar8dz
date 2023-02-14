﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] a = new int[4, 4]
{{1,4,7,2},
 {5,9,2,3},
 {8,4,3,4},
 {5,2,6,7}};
 int sum=0;
 int sum2=1000000;
 int str=0;
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int n=0;n<a.GetLength(1);n++)
    {   
        sum=sum+a[i,n];
    }
if (sum<sum2)
{
    sum2=sum;
    sum=0;
    str=i+1;
}
else{
    sum=0;
}
}
Console.WriteLine($"{str} строка = {sum2}");