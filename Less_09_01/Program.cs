Console.Write($"Введите N: ");
int N = int.Parse(Console.ReadLine()!);

string Print(int start, int end)
{
    if (start <= end)
        return start.ToString();
    return $"{start} {Print(start - 1, end)}";
}

Console.Write($"{Print(N, 1)}");