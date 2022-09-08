// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4
Console.Write("Введите цифры через запятую: ");
string userInput = Console.ReadLine() + ",";
userInput = userInput.Replace(" ", "");
int numbersCount= CountCommas(userInput);
if (userInput.Length==numbersCount)
    {
        Console.Write ("Цифр не обнаружено...");
        return;
    }
int zeros = CountZeros(userInput);
int minuses = CountMinuses(userInput);
Console.WriteLine (numbersCount-zeros-minuses);


int CountCommas(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ',')
            counter++;
    return counter;
}

int CountMinuses(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == '-')
            counter++;
    return counter;
}

int CountZeros(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == '0' && input[i-1] == ',' && input[i+1] == ',')
            counter++;
    return counter;
}