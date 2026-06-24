using Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace Commons.Helper
{
    public static class TelegramHelper
    {
        static readonly TelegramBotClient botClient = new TelegramBotClient("7484656620:AAEozZe8uVeRW36lVx1gnT0aSJ0SKpHXk7c");
        public static async Task StartReceiver()
        {
            var token = new CancellationTokenSource();
            var cancelToken = token.Token;
            var reOpt = new ReceiverOptions { AllowedUpdates = { } };
            await botClient.ReceiveAsync(OnMessage, ErrorMessage, reOpt, cancelToken);
        }
        public static async Task OnMessage(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message is Telegram.Bot.Types.Message message)
            {
                SendMessage(message);
            }
        }
        public static async Task ErrorMessage(ITelegramBotClient botClient, Exception e, CancellationToken cancellationToken)
        {
            if (e is ApiRequestException apiRequestException)
            {
                await botClient.SendTextMessageAsync("", e.Message.ToString());
            }
        }
        public static async Task SendMessage(Telegram.Bot.Types.Message message)
        {
            await botClient.SendTextMessageAsync(message.Chat.Id, "Hello world!");
        }
        public static async Task SendMessage(ChatId chatId, string message)
        {
            try
            {
                await botClient.SendTextMessageAsync(chatId, message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
