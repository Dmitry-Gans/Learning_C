int a = int.Parse(Console.ReadLine());

int sum = GetSumToNumber(a);
Console.WriteLine(sum);

int GetSumToNumber(int number)
{
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}