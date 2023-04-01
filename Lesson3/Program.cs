/*Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y)
*/
//| - или
//& - и
//|| - иключающий или
//&& - исключающий и

//  true       не проверяет   
//if(x == 0 || y == 0)
//  false       не проверяет
//if(x == 0 && y == 0)
Console.WriteLine("Введите X");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y");
int y = int.Parse(Console.ReadLine());

int result = GetNumberOfQuarter(x, y);
if(result == 0)
{
    Console.WriteLine("Х или У равны нулю. Данные введены не правильно");
    return; // Если ответ не правильные пишем retyrn чтобы остановить программу раньше времени
}
Console.WriteLine(result);

int GetNumberOfQuarter(int x, int y)/* Создаем свою функцию с своим названием, в ней указываем,
что она будет делать, чтобы потом просто писать ее название и обращаться к ней, чтобы заново не писать*/
{
    if(x > 0 && y > 0)
    {
        return 1;
    }
    if(x > 0 && y < 0)
    {
        return 2;
    }
    if(x > 0 && y > 0)
    {
        return 1;
    }
    if(x < 0 && y < 0)
    {
        return 3;
    }
    if(x > 0 && y < 0)
    {
        return 4;
    }
    return 0;
}


