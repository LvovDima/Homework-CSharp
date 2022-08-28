// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int numberInt = ReadInt("Введите число: ");
string numberStr = Convert.ToString(numberInt);

SumMath(numberInt, "Математическим методом");
SumString(numberStr, "Строчным методом");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SumMath(int a, string msg)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a % 10;
        a /= 10;
    }
    Console.WriteLine($"Cумма цифр равна {sum}. ({msg})");
}

void SumString(string input, string msg)
{
    int res = 0;
    string[] a = new string[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        a[i] = input[i].ToString();
        res += Convert.ToInt32(a[i]); 
    }
    Console.WriteLine($"Cумма цифр равна {res}. ({msg})");
}
