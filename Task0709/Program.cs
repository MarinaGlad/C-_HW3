/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число ");
string? digit = Convert.ToString(Console.ReadLine());
if(digit[0]==digit[4] && digit[1]==digit[3])
Console.WriteLine($"{digit} - число является палиндромом");
else Console.WriteLine($"{digit} - число не является палиндромом");


/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите цифру от 1 ");
int N = Convert.ToInt32(Console.ReadLine());
for (int start = 1; start <= N; start++)
{
    Console.WriteLine(Math.Pow(start, 3));
}





/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


Console.Write("Введите координату Х1 ");
int X1= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y1 ");
int Y1= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z1 ");
int Z1= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X2 ");
int X2= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y2 ");
int Y2= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z2 ");
int Z2= Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2) + Math.Pow(Z2-Z1, 2));
Console.WriteLine($"Расстояние между точками = {Math.Round(d, 2)}");

