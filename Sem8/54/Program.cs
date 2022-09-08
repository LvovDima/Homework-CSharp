// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
FillArray2D(array);
PrintArray2D(array);
SortRowsDecend(array);
PrintArray2D(array);



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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SortDescend(int[] array1)
{
    for (int i = 0; i < array1.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array1.Length; j++)
        {
            if (array1[j] > array1[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = array1[i];
        array1[i] = array1[maxPosition];
        array1[maxPosition] = temporary;
    }

}

void SortRowsDecend(int[,] array)
{
    int tmp = 0;
    int[] row = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i,j];
        }
        SortDescend(row);
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i,k] = row[k];
        }
    }
}