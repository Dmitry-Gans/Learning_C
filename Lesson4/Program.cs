int number = int.Parse(Console.ReadLine());

int[] array = ReverseArray(number);

int[] ReverseArray(int number)
{
    int length = new int[array.Length];
    int[] result = new int[];

    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array;
        number = number / 10;
    }
}
int GetLengthNumber(int number)
{
    int length = 0;
    while (number != 0)
    {
        number = number / 10;
        length++;
    }
    return length;
}