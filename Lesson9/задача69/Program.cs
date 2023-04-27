// Задача 69:
// Напишите программу, которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8

Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = int.Parse(Console.ReadLine());

int factorial = Factorial(a, b);

Console.WriteLine($"{a}, {b} -> {factorial}");

int Factorial(int a, int b)
{
    if (b > 0)
    {
        b = b - 1;// Убавляем b на 1 с каждым циклом, иначе будет бесконечность
        // в конечном итоге b будет 0, условие не выполнится, тогда возвраещаем 1
        // и в обратном порядке будет перемножение на a 
        return Factorial(a, b) * a;// 1 * 3 = 3; 3 * 3 = 9 и тд
    }
    return 1;// Возвращаем 1, чтобы умножение шло правильно
}


