Console.Write($"Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write($"Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);

double[,] array = new double[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round(new Random().NextDouble() * (10 - (-10)) + (-10), 1);
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