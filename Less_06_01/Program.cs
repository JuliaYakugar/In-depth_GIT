Console.Write("Сколько чисел вы будете вводить (М): ");
int[] array = new int [int.Parse(Console.ReadLine()!)];

int pol = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите число №{i+1}: ");
    array[i] = int.Parse(Console.ReadLine()!);
    if (array[i] > 0) pol++;
}

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}");
    if(i != array.Length-1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");

Console.WriteLine($"Больше нуля: {pol}");