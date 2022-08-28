// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]
Console.Clear();
CreateArray(ReadInt("Введите размер массива: "));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray (int size)
{
    int[] a = new int[size];
    for (int i=0; i<a.Length; i++) 
    {
        a[i] = new Random().Next(0, 100);
        Console.Write(a[i]+" ");
    }
    return a;
}
