// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

string input = ReadStr("Введите число больше 99: ");
int[] array = Decompose(input);
if (isItBigEnough(input) == true)
{
    Console.Write("Третья цифра: " + array[2]);
}
else
{
    Console.Write("Третьей цифры нет!");
}



string ReadStr(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

bool isItBigEnough(string a)
{
    return a.Length > 2;
}

int[] Decompose(string word)
{
    int size = word.Length;
    int wordToNumber = Convert.ToInt32(word);
    int[] a = new int[size];
    int i = 0;
    while (i < size)
    {
        a[size-1-i] = wordToNumber % 10;
        wordToNumber /= 10;
        i++;
    }
    return a;
}