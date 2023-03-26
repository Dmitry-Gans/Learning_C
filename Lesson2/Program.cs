/*Напишите программу, которая выводит случайное число из отрезка [10, 99]
и покажите наибольшую цифру числа:
*/

Random random = new Random();
int randomValue = random.Next(10,100);

int lastDigit = randomValue % 10;
int firstDigit = randomValue / 10;

Console.WriteLine(randomValue);

if(lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}  
else 
{
    Console.WriteLine(firstDigit);
}*/

