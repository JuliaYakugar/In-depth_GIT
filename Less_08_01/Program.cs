﻿int m = 3;
int k = 4;

int[,] array = new int[m,k];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < k; j++)
    {
        array[i, j] = new Random().Next(10);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < k; j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < k; j++)
        for (int l = 0; l < k; l++)
        {
            if (array[i,j] <= array[i,l]) continue;
            int max = array[i,j];
            array[i,j] = array[i,l];
            array[i,l] = max;
        }
}

Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < k; j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}