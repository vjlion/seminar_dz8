/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int m = 4;
int n = 4;
int[,] array = new int[m, n];

int i = 0;
int j = 0;
for (int steps = 1; steps <= m * n; steps++)
{
    array[i, j] = steps;
    if (i <= j + 1 && i + j < m - 1) j++;
    else if (i < j && i + j >= n - 1) i++;
    else if (i >= j && i + j > m - 1) j--;
    else i--;
}

for (int k = 0; k < n; k++)
{
    for (int l = 0; l < m; l++)
    {
        if (array[k, l] / 10 == 0) Console.Write($"0{array[k, l]} ");
        else Console.Write($"{array[k, l]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();