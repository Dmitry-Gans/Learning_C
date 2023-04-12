// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

//первый способ
/*
int num = 45;

int remains = 0;//Остаток от % деления на 2

int i = 0;//Шаг

string str = "";//Строка которая копит в себе двоичные числа

while (num >= 1)
{
    remains = num % 2;
    str += remains.ToString();
    i++;
    num = num / 2;
}
Console.WriteLine(str);
*/
//Второй способ

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
string result = "";
while (num >= 1)
{
    if (num % 2 == 0)
    {
        result = "0";
    }
    else if (num % 2 != 0)
    {
        result = "1";
    }
    Console.Write(result);
    num = num / 2;
}

