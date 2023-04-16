//Задача 46

int[,] array = Generate2DArray(3, 4);

void Printarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine(array[i, j]);
            Console.WriteLine(" ");
        }
        //Принудительный перенос строчки
        Console.WriteLine();
    }
}
int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine($"{i}, {j}");
            array[i, j] = random.Next(1, 15);
        }
    }
    return array;
}
