Console.Write("Введите число: ");
double A = double.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
double B = double.Parse(Console.ReadLine()!);

double p(double a, double b)
{
    return Math.Pow(a, b);
}

Console.Write($"Ответ: {p(A, B)}");