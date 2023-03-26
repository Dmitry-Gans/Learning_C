/*Задача No14. Общее обсуждение
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да*/
/*
Console.WriteLine("Введите число которое будет кратным для 7 и 23");
int num = int.Parse(Console.ReadLine());

if (num % 7 == 0 & num % 23 == 0)
{
    Console.WriteLine($"Число {num} является кратным для 7 и 23");
}
else
{
    Console.WriteLine($"Число {num} не вляется кратным для 7 и 23");
}
*/
/*Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
● 5, 25 -> да 
● -4, 16 -> да
● 25, 5 -> да
● 8,9 -> нет*/

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2)
{
    Console.WriteLine($"Число {num2} это {num1} в квадрате");
}
else if (num2 * num2 == num1)
{
    Console.WriteLine($"Число {num1} это {num2} в квадрате");
}
else
{
    Console.WriteLine($"Число {num1} не являются квадратом {num2}");
}
