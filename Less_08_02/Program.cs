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

int Sum(int i)
{
    int sum = 0;
    for (int j = 0; j < k; j++) 
        sum += array[i,j];
    
    return sum;
}

int min = Sum(0);
int str = 1;
for (int i = 0; i < m; i++)
{
    if (Sum(i) < min)
    {
        min = Sum(i);
        str = i+1;
    } 
}

Console.WriteLine();
Console.Write($"Строка с наименьшей суммой: {str}");