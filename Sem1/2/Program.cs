using System;
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if  (a > b) 
{
    Console.WriteLine("Максимальное из двух чисел = " + a);
}
else 
{
    Console.WriteLine("Максимальное из двух чисел = " + b);
}