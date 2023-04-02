/*Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число");
int max = int.Parse(Console.ReadLine());
int[] array = RandomArray(size, min, max);
PrintArray(array);
int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    Random random = new Random();

    for (int i = 0; i < array.Length; i++)

        array[i] = random.Next(min, max);

    Console.WriteLine("Ответ:");
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}