/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] array = new int[5];
FillArray(array, 0 , 100);
PrintArray(array);
int result = ValuesInDiapazon(array, 10, 99);
Console.WriteLine(result);

int ValuesInDiapazon(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max)
        {
            count ++;
        }
    }
    return count;
}

void FillArray(int[] array, int min, int max)//Добавляем переменные min и max
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max);//меняем числа на переменные min и max
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}