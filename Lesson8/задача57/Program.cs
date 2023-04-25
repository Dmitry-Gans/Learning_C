// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 4, 6, 1 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

int[,] array = GenerateArray(2, 8);

PrintArray(array);
Dictionary<int, int> result = SummIndexTimes(array);
foreach (var row in result)
{
    if (row.Value == 2 || row.Value == 3 || row.Value == 4)
    {
        Console.WriteLine($"Число: {row.Key}  встречается: {row.Value} раза");
    }
    else
    {
        Console.WriteLine($"Число: {row.Key}  встречается: {row.Value} раз");
    }
}
int[,] GenerateArray(int m, int n)
{

    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

Dictionary<int, int> SummIndexTimes(int[,] array)
{
    Dictionary<int, int> dic = new Dictionary<int, int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (!dic.TryAdd(array[i, j], 1))
            {
                dic[array[i, j]] += 1;
            }
        }
    }
    return dic;
}
