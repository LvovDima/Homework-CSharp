Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (a<=0)
{
    Console.Write("Введите положительное число или программа завершится: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a == 1) Console.Write("В промежутке от 1 до вашего числа четных чисел нет");
    else while (i <= a)
        {
            Console.Write(i+" ");
            i+=2 ;
        }
}
else
{
    if (a == 1) Console.Write("В промежутке от 1 до вашего числа четных чисел нет");
    else while (i <= a)
        {
            Console.Write(i+" ");
            i+=2 ;
        }
    
}