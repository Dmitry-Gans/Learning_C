/*int a = 5;

int b = 6;

int result = a * (a * b);

int c = 7;

int g = 8;

int result1 = Calculate(a, b);
Show(a,b);

int result2 = Calculate(c, g);
Show(c,g);

Console.WriteLine(result1);
Console.WriteLine(result2);

int Calculate(int a, int b);
{
    returne a * (a * b) - 5;
    
    /*Обычный способ написания:
    int result = a * (a * b) - 5;
    return result;
}*/
/*void Show(int a, int b);
{
    Console.WriteLine($"{a} , {b}");
}
Console.WriteLine(result);*/

/*Напишите программу, которая выводит случайное число из отрезка [10, 99]
и покажите наибольшую цифру числа:
*/

Random random = new Random();
int randomValue = random.Next(10,100);

int lastDigit = randomValue % 10;
int firstDigit = randomValue / 10;

Console.WriteLine(randomValue);

if(lastDigit > firstDigit)
{
    Console.WriteLine($"Второе число больше: {lastDigit}");
}  
else 
{
    Console.WriteLine($"Первое число больше: {firstDigit}");
}
