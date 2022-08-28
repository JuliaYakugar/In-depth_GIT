Console.Write("Введите 1 число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите 3 число: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write($"max = {max}");