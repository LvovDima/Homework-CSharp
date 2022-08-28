// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");

Console.WriteLine($"{numberA} в степени {numberB} = {power(numberA, numberB)}");


int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int power(int numberA, int numberB)
{
int result = 1;
for (int i = 0; i < numberB; i++) result *= numberA;
return result;
}






