Console.Write($"Введите M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write($"Введите N: ");
int N = int.Parse(Console.ReadLine()!);

int Ack(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    if ((M > 0) && (N == 0))
    {
        return Ack(M - 1, 1);
    }
    if ((M > 0) && (N > 0))
    {
        return Ack(M - 1, Ack(M, N - 1));
    }
    return Ack(M,N);
}

Console.WriteLine(Ack(M, N));