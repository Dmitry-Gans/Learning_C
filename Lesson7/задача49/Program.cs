// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 47 2
// 5 92 3
// 8 42 4
// Новый массив будет выглядеть вот так:
// 1 47 2
// 5 81 9
// 8 42 4
// 25 мин

int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangNumberArray(matrix);
PrintArray(matrix);
void ChangNumberArray(int[,] matrix)//Заменяем ячейку с четными индексами на квадрат
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i % 2 != 0)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j % 2 != 0)
                {
                    matrix[i, j] = matrix[i, j] * matrix[i, j];
                }
            }
        }
    }
}
void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }

        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }

}