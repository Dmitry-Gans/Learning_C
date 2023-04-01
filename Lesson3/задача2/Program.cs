/*Задача No21. Работа в группах
Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21
*/
//Решение без метода
/*
Console.WriteLine("Введите A");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите A");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите B");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите B");
int yb = int.Parse(Console.ReadLine());

double resultPowX = Math.Pow(xb - xa, 2);
double resultPowY = Math.Pow(yb - ya, 2);

double result = Math.Sqrt(resultPowX + resultPowY);
Console.WriteLine(result);
*/
//Решение с методом

Console.WriteLine("Введите ax");
double ax = double.Parse(Console.ReadLine());
Console.WriteLine("Введите ay");
double ay = double.Parse(Console.ReadLine());
Console.WriteLine("Введите bx");
double bx = double.Parse(Console.ReadLine());
Console.WriteLine("Введите by");
double by = double.Parse(Console.ReadLine());

double distance = GetDistance(ax, ay, bx, by);

Console.WriteLine($"расстояние между точками {distance}");

double GetDistance (double ax, double ay, double bx, double by)
{
    return Math.Sqrt(Math.Pow((bx - ax),2) + Math.Pow((by - ay),2));
}