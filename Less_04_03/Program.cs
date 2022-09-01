int[] Mas()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] array = Mas();
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}");
    if(i != array.Length-1)
    {
        Console.Write(", ");
    }
}
Console.Write("]");