int number = new Random().Next(100, 1000);

int n = number / 10 % 10;

Console.WriteLine($"Трехзначное число: {number}\nВторая цифра: {n}");