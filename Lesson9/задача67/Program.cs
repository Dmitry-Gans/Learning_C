// Задача 67:
// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12 45 -> 9

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int sum = NumSum(num);
Console.WriteLine($"{num} ->{sum}");

int NumSum(int num)
{
    if (num > 0)
    {
        int sum = num % 10;
        num = num / 10;
        return NumSum(num) + sum;// 0 + 3; 3 + 5 и тд
    }

    return 0;// Возвращаем 0, чтобы сумма складывалась правильно

}