Console.Write("Введите 1 число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b) Console.Write($"max = {a}");
else Console.Write($"max = {b}");