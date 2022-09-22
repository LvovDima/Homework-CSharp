// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int number1 = ReadInt("Введите 1-е число: ");
int number2 = ReadInt("Введите 2-e число: ");
Console.Write(RangeSum(number1, number2));




int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int RangeSum (int n, int m)
{
    
    if (m == n)
        return m;
    else 
    {
        int sum = m;
        sum+=RangeSum(n, m -1);
        return sum;
    }
}