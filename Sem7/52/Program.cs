// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int rows = ReadInt("Введите количество строк (не больше 9): ");
int cols = ReadInt("Введите количество столбцов (не больше 9): ");
bool sizeRestrictions = false;
while (!sizeRestrictions)
{
    if (cols >= 0 && cols < 10 && rows >= 0 && rows < 10)
    {
        sizeRestrictions = true;
    }
    else
    {
        Console.WriteLine("Некорректный ввод!");
        rows = ReadInt("Введите количество строк (НЕ БОЛЬШЕ 9): ");
        cols = ReadInt("Введите количество столбцов (НЕ БОЛЬШЕ 9): ");
    }
}

int[,] numbers = new int[rows, cols];
FillArray2D(numbers);
PrintArray2D(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum += numbers[i, j];
    }
    double avg = Convert.ToDouble(sum) / numbers.GetLength(0);
    Console.WriteLine($"{Math.Round(avg,2)}");
}




int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
