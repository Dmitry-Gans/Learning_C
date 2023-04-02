﻿/*
| - или
& - и
|| - иключающий или
&& - исключающий и

    true       не проверяет   
if(x == 0 || y == 0)
    false       не проверяет
if(x == 0 && y == 0)
*/
/*Задача No17. 
Напишите программу, которая принимает на вход координаты точки (Х и У),
причем Х и У не равены 0 и выдает номер четверти плоскости, в которой находится эта точка
*/

Console.WriteLine("Введите X");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y");
int y = int.Parse(Console.ReadLine());

int result = GetNumberOfQuarter(x, y);
Console.WriteLine($"{result} четверть");

if(result == 0)
{
    Console.WriteLine("Х или У равны нулю. Данные введены не правильно");
    return; // Если ответ не правильные пишем retyrn чтобы остановить программу раньше времени
}

int GetNumberOfQuarter(int x, int y)/* Создаем свою функцию с своим названием, в ней указываем,
что она будет делать, чтобы потом просто писать ее название и обращаться к ней, 
чтобы заново не писать
*/
{
    if(x > 0 && y > 0)
    {
        return 1;
    }

    if(x < 0 && y > 0)
    {
        return 2;
    }

    if(x < 0 && y < 0)
    {
        return 3;
    }
    
    if(x > 0 && y < 0)
    {
        return 4;
    }
/*
Если метод не выполнил ни один вариант, то нужно вернуть любое дефолтное значение, 
например 0, иначе метод не срабоатет, так как он возвратный 
*/ 
    return 0;
}
