
/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B. */

Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int step = numA;

for (int i = 1; i < numB; i++)
{
    step = step * numA;
}
Console.WriteLine("A в степени В равно: " + step);



Console.Clear();
Console.WriteLine("Enter num: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter Pow");
int rank = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} в степени {rank} = {Pow(num, rank)}");
int Pow(int num, int rank)
{
    if (rank == 0) return 1;
    else if (rank == 1) return num;
    else if (num == 0 || num == 1) return num;

    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }
    return result;
}



/* Напишите программу, каторая принимает на вход число А 
и выдаёт сумму чисел от 1 до А.
 */

Console.WriteLine("Введите число : ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до{limit} равна {GetSum(limit)}");

int GetSum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
        sum += i;

    return sum;
}


/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();

int[] array = GetRandomArray(8, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}