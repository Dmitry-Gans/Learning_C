// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 47 2
// 5 82 3
// 8 42 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SumArray(matrix);
PrintArray(matrix);
int[,] SumArray(int[,] matrix)
{
    int[,] sum = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        matrix.GetLength(0)[i] -= 1;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                sum = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];
            }
    }
    return sum;
       
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