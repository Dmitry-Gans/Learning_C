/*Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y)
*/
Console.WriteLine("Введите номер четверти");
int x = int.Parse(Console.ReadLine());
string range = GetRangeByQuarter(x);//Диапозон
Console.WriteLine(range);

string GetRangeByQuarter(int x)
{
    if (x == 1)
    {
        return "x > 0 и y > 0 ";
    }
    if (x == 2)
    {
        return "x > 0 и y < 0 ";
    }
    if (x == 3)
    {
        return "x < 0 и y < 0 ";
    }
    if (x == 4)
    {
        return "x > 0 и y < 0 ";
    }
    return " ";
}


