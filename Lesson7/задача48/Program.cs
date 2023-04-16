// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: A = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится
// по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4. 0 1 23
// 1 2 34
// 2 3 45

int[,] table = new int[3, 4];

FillArray(table);
PrintArray(table);

void PrintArray(int[,] tab) 
{
table[1, 2] = 5;

for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        Console.Write($" -{table[rows, columns]}-");
    }
Console.WriteLine();
}
}

void FillArray(int[,] tab)
{
for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        tab[rows, columns] = rows + columns;
    }
Console.WriteLine();
}
}