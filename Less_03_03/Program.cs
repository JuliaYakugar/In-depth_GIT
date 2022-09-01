Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

void Cube()
{
    for (int i = 1; i <= N; i++) Console.Write($"{Math.Pow(i, 3)} ");
}
Cube();