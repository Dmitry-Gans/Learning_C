/*Задача No1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет

Console.WriteLine("Программа определения является ли число А квадратом числа В");

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Число a является корнем числа b");
}

else
{
    Console.WriteLine("Число a не является коренм числа b");
}*/

/*Задача No3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/

/*Console.WriteLine("Введите значение от 1 до 7");
int a= int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.Write("Погедельник");
}

if (a == 2)
{
    Console.Write("Вторник");
}

if (a == 3)
{
    Console.Write("Среда");
}
if (a == 4)
{
    Console.Write("Четверг");
}

if (a == 5)
{
    Console.Write("Пятница");
}

if (a == 6)
{
    Console.Write("Суббота");
}

if (a == 7)
{
    Console.Write("Воскресение");

}

if(a < 1 & a > 7)
{
    Console.Write("Такого дня не существует");
}*/


/*Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

/*Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

int a = -N;

while(a <= N)
{
    Console.WriteLine(a);
    a ++;
}*/

/*Задача No7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6 782 -> 2 918 -> 8
*/

Console.WriteLine("Введите трехзначное число");

int a = int.Parse(Console.ReadLine());

if (a > 99 & a <= 999)
{
    Console.WriteLine(a % 10);
}
else
{
    Console.WriteLine("Введите правильное количество чисел");
}