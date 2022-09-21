// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
int number = ReadInt("Введите число: ");
Console.Write ($"{NaturalReverse(number+1)} ");



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NaturalReverse(int n)
{
    if (n <= 2) 
        return 1;
    else
    {

        n--;
        Console.Write ($"{n} ");
        n=NaturalReverse(n);
    }
     
 return n;
}