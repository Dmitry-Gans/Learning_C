/* Задача 28: Напишите программу, которая принимает на вход число N
и выдаёт произведение чисел от 1 до N.
4 -> 24 5 -> 120*/
Console.WriteLine("Введите число N");

int a = int.Parse(Console.ReadLine());

int result = Factorial(a);
Console.WriteLine(result);

int Factorial(int a)
{
    int factorial = 1;
    for (int i = 1; i <= a; i++)
    {
        factorial *= i;
    }
    return factorial;
}
