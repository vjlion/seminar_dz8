/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] PrintMatrix(int row, int col)
{
    int[,] matr = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matr[i, j] = new Random().Next(2, 5);
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matr;
}
void CreateMatrix(int[,] array, int[,] array1)
{
    int[,] newArray = new int[array.GetLength(0), array1.GetLength(1)];
    if (array.GetLength(1) != array1.GetLength(0))
    {
        Console.WriteLine("Нельзя вычислить ");
        return;
    }
    else
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                int multiplication = 0;
                for (int k = 0; k < array1.GetLength(0); k++)
                {
                    multiplication += array[i, k] * array1[k, j];
                }
                newArray[i, j] = multiplication;
                Console.Write(newArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

int m = 2, n = 2, m1 = 2, n1 = 2;
int[,] matrix = PrintMatrix(m, n);
Console.WriteLine();
int[,] matrix1 = PrintMatrix(m1, n1);
Console.WriteLine("\nПроизведение матриц \n");
CreateMatrix(matrix, matrix1);
Console.WriteLine();
