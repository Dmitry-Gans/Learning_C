// Задача 63:
// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Замеры:

// Stopwatch stopWatch = new Stopwatch();
// stopWatch.Start();
// //Print(number);
// Console.WriteLine();
// stopWatch.Stop();
// long tmp = stopWatch.ElapsedMilliseconds;

// stopWatch.Start();
// PrintCycle(number);
// Console.WriteLine();
// stopWatch.Stop();
// Console.WriteLine(tmp);
// Console.WriteLine(stopWatch.ElapsedMilliseconds);

Console.WriteLine("Введите число N");
int num = int.Parse(Console.ReadLine());
Array(num);
void Array(int num, int i = 1)// Задаем 1, чтобы она шла по умолчанию
{
    if (i <= num)
    {
        Console.Write($"{i}, ");
        Array(num, i + 1);
    }
}