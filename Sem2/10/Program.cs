int number = ReadInt("Введите трехзначное число: ");
bool i = false;
while (i == false)
{
    if (isIt3Digit(number) == i)
    {
        number = ReadInt("Введенное число не является трехзначным. Введите трехзначное число: ");
    }
    else
    {
        Console.WriteLine("Вторая цифра числа: " + Get2ndDigit(number));
        i = true;
    }
} 



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int Get2ndDigit(int a)
{
    int res = (a / 10) - ((a / 100) * 10);
    return res;
}


bool isIt3Digit (int a)
{
    bool i = (a > 99) && (a < 1000);
    return i; 
}
