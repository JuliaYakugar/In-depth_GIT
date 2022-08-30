Console.Write("Введите пятизначное число: ");
string str = Console.ReadLine()!;

string Expand(string str) 
{
    string newStr = "";
    for (int i = str.Length; i > 0; i--)
    {
        newStr = newStr + str[i-1];
    }
    return newStr;
}

if (str == Expand(str)) Console.Write("Палиндром");
else Console.Write("Не палиндром");