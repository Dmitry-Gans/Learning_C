/*Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

int num = int.Parse(Console.ReadLine());

int[] array = new int[10];
FillArray(array);
PrintArray(array);
bool result = IsNumberInArray(array, num);
Console.WriteLine((result)?"Да" : "Нет");//Console.WriteLine(result);
// Сокращеный аналог записи if-else, ?"Да" : "Нет" - тернарный оператор

bool IsNumberInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            return true;
        }
    }
    return false;
}

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