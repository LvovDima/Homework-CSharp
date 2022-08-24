// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
string message = ReadStr("Введите пятизначное число: ");
while (!isIt5(message))
{
   message = ReadStr("Введенное число не является пятизначным. Введите ПЯТИЗНАЧНОЕ число: ");
}

if (!Palindrome5Check(message))
{
   Console.Write ($"{message} -> нет");
}
else
{
   Console.Write ($"{message} -> да");
}



string ReadStr(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

bool Palindrome5Check (string input)
{
   return input[0] == input[4] && input[1] == input[3];
}

bool isIt5 (string input)
{
   if (input.Length == 5)
   {
      return true;
   }
   else
   { 
      return false;
   }
}