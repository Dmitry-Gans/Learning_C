/*Задача No22. Работа в группах
Напишите программу, которая принимает на вход число (N) и
выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4
*/
//Решение без метода
/*
Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    Console.WriteLine(i * i);
}
*/
//Решение с методом
Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());
Metod(a);
void Metod(int a)
{
    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine(i * i);
    }
}
