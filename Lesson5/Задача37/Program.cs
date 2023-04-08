/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] array = new int[5];
FillArray(array);
PrintArray(array);
int[] array2 = MultiplicationOfPairs(array);
PrintArray(array2);
int[] MultiplicationOfPairs(int[] array)
{
    int[] array2 = new int[array.Length / 2 + array.Length % 2];/*Длина нового массива
    с которой мы работаем, делим на 2, и делим через процент, чтобы работать с нечетными*/
    //Диапозон для шага i сокращаем на половину
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    {
        if (i == array.Length - 1 - i)//Шаг равен длине в середине
        {
            array2[i] = array[i];//Перезаписываем чтобы не перемножалось само на себя
            return array2; 
        }
        else
        { 
            array2[i] = array[i] * array[array.Length - 1 - i];
        }
    }
    return array2;
}
/*int MultiplicationOfPairs(int[] array)
{
    int is_chetnoe = array.Length % 2;
    int[] array2 = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array2.Length; i++)
    {
        if (i == array.Length / 2 + is_chetnoe)
        {
            Console.WriteLine(array[i]);
            array[i] = -1000;
            break;
        }
        array2[i] = array[i] * array[array.Length - 1 - i];

    }
}*/
void FillArray(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 11);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}