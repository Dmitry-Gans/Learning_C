/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
● 456 -> 46
● 782 -> 72
● 918 -> 98*/
//Первый способ через string:

/*Random rundom = new Random();
int rundomValue = rundom.Next(100, 1000);

int first = rundomValue / 100;
int last = rundomValue % 10;

string result = $"{first}{last}";
Console.WriteLine(rundomValue);
Console.WriteLine("Стираем второе число");
Console.WriteLine(result);
*/

//Второй способ, просто через числа:

Random rundom = new Random();
int rundomValue = rundom.Next(100, 1000);//Получаем случайное число в диапазоне 100 - 1000

int first = rundomValue / 100;//Получаем первое число
int last = rundomValue % 10;//Получаем последнее число

Console.WriteLine($"{rundomValue}->{first}{last}");//Объединяем первое и последнее число 

/*Задача No12. Работа в группах
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
● 34, 5 -> не кратно, остаток 4
● 16, 4 -> кратно*/

/*int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine($"{num1} кратное {num2}");
}
else
{
    Console.WriteLine($"{num1 % num2} не кратное");
}*/