// Задача 40: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

bool exist = IsTriangleExist(a, b, c);
Console.WriteLine((exist)?"Может":"Не может");

bool IsTriangleExist(int a, int b, int c)
{
    if (a + b < c)
    {//Если сумма двух сторон меньше третьей стороны,
    //этого не может быть, возвращаем false 
        return false;
    }
    if (a + c < b)
    {
        return false;
    }
    if (c + b < a)
    {
        return false;
    }
    //Если используем return, то else можно не использовать,
    //сразу пишем return true
    return true;
}