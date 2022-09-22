int m = 3;
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

int[] average = new int[k];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < k; j++)
    {
        average[j] += array[i,j];
    }
}
Console.WriteLine();
for (int i = 0; i < k; i++)
{
    Console.Write($"{Math.Round((double)average[i]/m, 1)} ");
}