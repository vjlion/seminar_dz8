/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[] GetMatrix(int min, int max) 
{
    int[] num = new int[max - min + 1];
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = min + i;
    }

    for (int i = 0; i < num.Length - 1; i++)
    {
        int index = new Random().Next(i + 1, num.Length);
        int temp = num[i];
        num[i] = num[index];
        num[index] = temp;
    }
    return num;
}

int min = 10, max = 99, count = 10;

int[] uniqueValuesNum = GetMatrix(min, max);
int[,,] threeArray = new int[2, 2, 2];
for (int i = 0; i < threeArray.GetLength(0); i++)
{
    for (int j = 0; j < threeArray.GetLength(1); j++)
    {
        for (int k = 0; k < threeArray.GetLength(2); k++)
        {
            threeArray[i, j, k] = uniqueValuesNum[count];
            Console.Write($"{threeArray[i, j, k]}({i},{j},{k}) ");
            count++;
        }
        Console.WriteLine();
    }
}

Console.WriteLine();