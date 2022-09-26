Console.Write($"Введите M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write($"Введите N: ");
int N = int.Parse(Console.ReadLine()!);

string Sum(int M, int N, int sum)
{
    if (M > N)
        return $"{sum}";
    sum += M;
    return $"{Sum(M + 1, N, sum)}";
}

Console.Write($"{Sum(M, N, 0)}");