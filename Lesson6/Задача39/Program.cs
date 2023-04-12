// Задача 39 
// Напишите программу, которая перевернет
// одномерный массив(последний элемент будет на первом месте,
// а первый - на последнем и тд.)
// [12345] -> [54321]

//Вариант с созданием двух масивов

int[] arr = new int[]{5, 8, 1, 3, 9};
PrintArray(arr);
/*
int[] reverse = Reverse(arr);
PrintArray(reverse);

int[] Reverse(int[] array)
{
    int[] reverse = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reverse[i] = array[array.Length - 1 - i];
    }
    return reverse;
}
*/
 void PrintArray(int[] array)
 {
    Console.WriteLine(string.Join(", ", array));
 }

// Вариант через void

Reverse(arr);
PrintArray(arr);

void Reverse(int[] array)
{
    //Обязательно делим длину на 2, иначе массив не перевернется 
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];//Создаем новую переменную tmp, 
        //чтобы в ней хранить первое число
        array[i] = array[array.Length - 1 - i];//Затем первую 
        //перезаписываем на последнюю
        array[array.Length - 1 - i] = tmp;//И в последнюю кладем 
        //переменную tmp с первым числом
    }
}