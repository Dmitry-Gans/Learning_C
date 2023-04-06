//Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int sum = GetSumToNumber(a);
Console.WriteLine(sum);

int GetSumToNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}