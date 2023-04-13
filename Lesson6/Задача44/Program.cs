// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
/*
Console.WriteLine("Введите число");
double num = double.Parse(Console.ReadLine());

double FibonacciN(int num)
{
    if(num == 1 || num == 2) return 1;
    else if(num == 0) return 0;
    else return FibonacciN(num - 1) + FibonacciN(num - 2);
}
for (int i = 0; i < num; i++)
{
    Console.Write(FibonacciN(i));
}
*/
//Решение через массив:

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int[] result = FibonacciN(num);
PrintArray(result);
int[] FibonacciN(int num)
{
    int[] array = new int[num];
    //Вводим array 0 и 1, через условие, чтобы правильно заполненить массив
    if (array.Length > 0)
    {
        array[0] = 0;
    }
    if (array.Length > 1)
    {
        array[1] = 1;
    }
    //В цикле начинаем с 2, так как 0 и 1 уже заполнили выше
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}