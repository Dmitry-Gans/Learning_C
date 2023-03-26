/*Задача No14. Общее обсуждение
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да*/

/*int num1 = int.Parse(Console.ReadLine());

if (num1 % 7 == 0 & num1 % 23 == 0)
{
    Console.WriteLine("The number is miltiple to botch 7 and 23");
}
else
{
    Console.WriteLine("The number isn't miltiple to botch 7 and 23");
}
*/

/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
● 5, 25 -> да ● -4, 16 -> да ● 25, 5 -> да ● 8,9 -> нет*/
Console.WriteLine("Please input the first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please input the second number");
int num2 = int.Parse(Console.ReadLine());

/*if (num2 * num2 == num1 | num1 * num1 == num2)
{
    Console.WriteLine("num1 is num2 squared or the opposite");
}
else
{
    Console.WriteLine("num1 of the numbers are squares of each other");
}*/

if (num2 * num2 == num1)
{
    Console.WriteLine("num1 is num2 squared");
}
else if (num1 * num1 == num2)
{
    Console.WriteLine("num2 is num1 squared");
}
else
{
    Console.WriteLine("num1 of the numbers are squares of each other");
}