// dotnet add package Telegram.Bot - подключаем нужную библиотеку дял рабоыт с ботом
// Далее прописываем Юзинги 

using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;

//Создаем обьект класса "TelegramBotClient" работа с ним так же как и с Random
//В ковычках указываем токен от тлеграм Бота
TelegramBotClient client = new TelegramBotClient("6038050382:AAF-eRSW-QkRXr02IiMXZfN5WSxGHtNKXuE");

//Узнаем пользователя
User user = await client.GetMeAsync();
//Показываем UserName бота
Console.WriteLine(user.Username);

//Чтобы программа работала бесконечно, запускаем цикл
while (true)
{
    //Создаем массив обновлений: кто то добавился, написал и тд
    Update[] update = await client.GetUpdatesAsync();
    for (int i = 0; i < update.Length; i++)
    {   //Показываем смс текст
        Console.WriteLine(update[i].Message.Text);
        //Показываем отправителя смс
        Console.WriteLine(update[i].Message.From.FirstName);
        //Можно добавлять условия
        if(update[i].Message.Text == "Привет")
        {   //Отправляем ответное смс и обращаемся к имени отправителя
            await client.SendTextMessageAsync(update[i].Message.From.Id, $"Привет {update[i].Message.From.FirstName}");
        }
        //Показываем сообщение и его отправителя, отправляем ответное смс
                                                   //смс   id отправителя        
        //await client.SendTextMessageAsync(update[i].Message.From.Id, "Текст сообщения");
    }
    //Чтобы пропускать некоторые обновления
    if (update.Length != 0)
    {//Обращаемся к последнему обновлению Id, говорим, присылай все после него
    //Чтобы консоль не показывала одно и тоже обноление повторно
        update = await client.GetUpdatesAsync(update[update.Length-1].Id + 1);
    } 
}
