int number = new Random().Next(1, 8);

if(number == 6 || number == 7)
    Console.Write($"{number} -> Выходной");
else
    Console.Write($"{number} -> Рабочий");