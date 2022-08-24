/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();
int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int z1 = ReadInt("Введите Z точки A: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");
int z2 = ReadInt("Введите Z точки B: ");

int lenghX = x1 - x2;
int lenghY = y1 - y2;
int lenghZ = z1 - z2;
double distance = Math.Sqrt(lenghX * lenghX + lenghY * lenghY + lenghZ * lenghZ);
Console.WriteLine($"A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2}) -> {distance}");

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}