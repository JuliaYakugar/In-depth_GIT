int[] array = new int[10];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i]%2 == 0) count++;
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

Console.Write($"Четных: {count}");