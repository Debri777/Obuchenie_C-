﻿/*Задача 19

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
