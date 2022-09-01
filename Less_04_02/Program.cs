Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

int sum = 0;
void Sum(int a)
{
    if (a > 0)
    {
        sum += a % 10;
        Sum(a/10);
    }
}
Sum(A);
Console.Write($"Сумма цифр: {sum}");