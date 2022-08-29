// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76
Console.Clear();
int size = ReadInt("Введите размер массива: ");
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
MinMax(numbers);
// Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {MinMax(numbers)}");
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + "  ");
}
Console.WriteLine();
}

void FillArrayRandomNumbers(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 10) + 0.01 * new Random().Next(0, 101);
}
}

void MinMax(double[] array)
{
    double result = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    //result = max - min;
    Console.WriteLine($"Максимальный элемент массива: {max}");
    Console.WriteLine($"Минимальный элемент массива: {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max - min}");
    //return result;
}