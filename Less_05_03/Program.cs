int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
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

int min = array[0];
int max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.Write($"Разница: {max-min}");