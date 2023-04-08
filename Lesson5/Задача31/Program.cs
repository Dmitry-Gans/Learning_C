/*Задача 31:
Задайтте массив из 12 элементов, заполните случайными числами
из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов масиива.
Например:
[3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных 
чисел ровна 29, сумма отрицательных равна -20.
*/
int[] array = GenerationArray(12);
PrintArray(array);

int sum = CalculateSumPositive(array);
int sum1 = CalculateSumNegative(array);
Console.WriteLine($"Сумма положительных чисел = {sum}, Сумма отрицательных чисел = {sum1}");

int[] GenerationArray(int lenght)//Созздаем метод для генирации масива и его длинны 
{
    int[] array = new int[lenght];

    Random random = new Random();

    for (int i = 0; i < lenght; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");/*Вписываем в ковычках,
    через какой символ будут чередоваться числа в массиве.
    После ковычек ставим запятую и сам массив, который в последствии превращается
    в строчку*/
}

int CalculateSumPositive(int[] array)
{
    int sumPositiv = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
        sumPositiv += array[i];//sumPositiv = sumPositiv + array[i]
        }
    }
    return sumPositiv;
}
int CalculateSumNegative(int[] array)
{
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        sumNegative += array[i];
    }
    return sumNegative;
}