// Задача 65:
// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Array(n, m);
void Array(int n, int m)
{
    if (m <= n)
    {
        Console.Write($"{m}, ");
        Array(n, m + 1);
    }
}