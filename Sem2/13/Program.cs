Console.Clear();
string input = ReadInt("Введите число: ");
int number = Convert.ToInt32(input);
if(number > 99)
{
    Console.Write("Третья цифра числа: " + Prune(input, 3) % 10);
}
else
{
    Console.Write("В введенном числе нет третьей цифры");
}


string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

int Prune(string message, int i)
{
    int size = message.Length;
    int res = Convert.ToInt32(message);
    while (size > i)
    {
        res /= 10;
        size--;
    }
    return res;
}

