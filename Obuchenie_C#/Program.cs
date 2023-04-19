/*Задача 19

/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
Console.Clear();
Console.WriteLine("Enter a number: ");
string number = Console.ReadLine();
int i = number.Length;

if (i == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Corresponds to-Palindrome");
    }
    else
    {
        Console.WriteLine($"{number} - Does not match-Palindrome");
    }
}
else
{
    Console.WriteLine($"{number} - not a five-digit number: ");
}

/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53*/

Console.Clear();
Console.Write("Enter X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Enter Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Enter Z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Enter X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Enter Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Enter Z2: ");
int z2 = int.Parse(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"d={d:f3}");

/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i * i * i}");
}