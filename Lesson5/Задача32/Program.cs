/*
Задача 32: Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
int[] array = new int[5];

FillArray(array);

PrintArray(array);

ChangeSignOfNumbers(array);

PrintArray(array);

void FillArray(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }
}
void ChangeSignOfNumbers(int[] array)//Cоздаем метод для замены минуса/плюса
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}