int m = 3;
int n = 4;

int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(10);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

void Search(int a, int b)
{
    if ((a <= m) && (b <= n)) 
    {
        Console.Write(array[a-1, b-1]);
    }
    else
    {
        Console.Write("Такого числа нет");
    }
}

Console.Write($"В каком столбце вас интересует значение? ");
int b = int.Parse(Console.ReadLine()!);
Console.Write($"В какой строке вас интересует значение? ");
int a = int.Parse(Console.ReadLine()!);
Search(a, b);