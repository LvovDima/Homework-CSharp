Console.Clear();
int day = ReadInt("Введите число от 1 до 7, обозначающее день недели: ");

while ((day > 7) || (day <1))
{
    day = ReadInt("Некорректный ввод, введите ещё раз: ");
}

if (DayOff(day) == true)
{
    Console.Write("Этот день является выходным");
}
else
{
    Console.Write("Этот день не является выходным");
}



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool DayOff (int i)
{
    bool res = (i == 6) || (i == 7);
    return res;
}