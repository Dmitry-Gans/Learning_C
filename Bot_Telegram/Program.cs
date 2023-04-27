// dotnet add package Telegram.Bot - подключаем нужную библиотеку дял рабоыт с ботом
// Далее прописываем Юзинги 

using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;

// Создаем обьект класса "TelegramBotClient" работа с ним так же как и с Random
// В ковычках указываем токен от тлеграм Бота
TelegramBotClient client = new TelegramBotClient("6038050382:AAF-eRSW-QkRXr02IiMXZfN5WSxGHtNKXuE");
// Лист тоже самое что и массив. но умеет расширяться
// Это будет список людей, которым кидать рассылку
List<long> users = new List<long>();
// Заводим админа, чтобы у него был доступ к рассылки
long adminId = 0;
// Задаем таймер на оповещение
DateTime dateAlert = DateTime.Now;
// Узнаем пользователя
User user = await client.GetMeAsync();
// Показываем UserName бота
Console.WriteLine(user.Username);

// Чтобы программа работала бесконечно, запускаем цикл
while (true)
{
    // Создаем массив обновлений: кто то добавился, написал и тд
    Update[] update = await client.GetUpdatesAsync();
    for (int i = 0; i < update.Length; i++)
    {
        SendGoose(update[i]);
        // Добавляем проверку, если пользоваетль напишет пароль, то он становится админом
        if (update[i].Message.Text == "123")
        {
            adminId = update[i].Message.From.Id;
        }
        // Проверка на время, чтобы вовремя запустить оповещение
        if (DateTime.TryParse(update[i].Message.Text, out DateTime date))
        {
            Console.WriteLine(date);
            dateAlert = date;
            SendAlert();
        }
        // Добавляем проверку, если users не содержит user id, то тогда добавляем в список usrers.
        // так же исключаем самого админа из списка usrers
        if (!users.Contains(update[i].Message.From.Id) && update[i].Message.From.Id != adminId)
        {
            Console.WriteLine(update[i].Message.From.Id);
            // Добавляем пользователя, который нам написал в список usrers
            users.Add(update[i].Message.From.Id);
        }// Если написал администратор, то сообщение будет рассылаться всем
        if (adminId == update[i].Message.From.Id)
        {
            // Отправляем смс пользователям, написанное в чате Телеграм.
            // Я напишу там "как дела?" и это смс отправится всем пользователям в чате 
            SendMessengeToAllUsers(update[i].Message.Text);
        }
        // Показываем смс текст
        Console.WriteLine(update[i].Message.Text);
        // Показываем отправителя смс
        // Console.WriteLine(update[i].Message.From.FirstName);
        // Можно добавлять условия
        /*if(update[i].Message.Text == "Привет")
        {   //Отправляем ответное смс и обращаемся к имени отправителя
            await client.SendTextMessageAsync(update[i].Message.From.Id, $"Привет {update[i].Message.From.FirstName}");
        }*/
        // Показываем сообщение и его отправителя, отправляем ответное смс
        // смс   id отправителя        
        // await client.SendTextMessageAsync(update[i].Message.From.Id, "Текст сообщения");
    }
    // Чтобы пропускать некоторые обновления
    if (update.Length != 0)
    {// Обращаемся к последнему обновлению Id, говорим, присылай все после него
     // Чтобы консоль не показывала одно и тоже обноление повторно
        update = await client.GetUpdatesAsync(update[update.Length - 1].Id + 1);
    }
}
// Создаем метод для вывода картинок
void SendGoose(Update update)
{
    if (update.Message.Text.ToLower() == "хочу гуся")
    {
        StreamReader reader = new StreamReader("Гусь.jpeg");
        client.SendPhotoAsync(update.Message.From.Id, reader.BaseStream);
    }
}
// Создаем фоновый метод, который будет бесконеячным, для определния уведомлений
void SendAlert()
{// Искуственно запускаем бесконечность, фоновой задачей
    Task.Run(() =>
    {
        while (true)
        {//Если настоящее время(+15 минут) == Времени оповещения
            if (DateTime.Now.AddMinutes(15) == dateAlert)
            {
                SendMessengeToAllUsers($"Загнятие начнется через {15} минут");
                return;
            }
            if (DateTime.Now == dateAlert)
            {
                SendMessengeToAllUsers($"Загнятие началось");
                return;
            }
        }
    });
}
// Создаем метод для отправки смс всем пользователям
void SendMessengeToAllUsers(string text)
{
    for (int i = 0; i < users.Count; i++)
    {//                             Кому отправляем       Сообщение
        client.SendTextMessageAsync(new ChatId(users[i]), text);
    }
}

