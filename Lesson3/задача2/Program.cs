/*Задача No21. Работа в группах
Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21
*/
//Решение без метода
/*
Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());

double resultPowX = Math.Pow(x2 - x1, 2);
double resultPowY = Math.Pow(y2 - y1, 2);

double result = Math.Sqrt(resultPowX + resultPowY);
Console.WriteLine(result);
*/
//Решение с методом

Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());

double distance = GetDistance(x1, y1, x2, y2);//Переводим int в double, чтобы вычисления были точными

Console.WriteLine($"расстояние между точками {distance}");

double GetDistance (double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
}