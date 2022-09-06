int[] array = new int[10];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    if (i%2 != 0) sum += array[i];
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

Console.Write($"Сумма: {sum}");