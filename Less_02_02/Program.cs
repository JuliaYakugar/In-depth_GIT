int number = new Random().Next(1000000);

if (number < 100)
    Console.Write($"{number} -> Третьей цифры нет");
else
    Console.Write($"{number} -> {number.ToString()[2]}");