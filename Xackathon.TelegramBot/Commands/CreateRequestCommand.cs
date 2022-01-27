using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Xackathon.TelegramBot.Resources;

namespace Xackathon.TelegramBot.Commands
{
    public class CreateRequestCommand : ICommand
    {
        private readonly ITelegramBotClient _bot;

        public CreateRequestCommand(ITelegramBotClient bot)
        {
            _bot = bot;
        }
        public bool CanExecute(Update msg) => msg?.Message?.Text == "/create_request";

        public async Task Execute(Update msg)
        {
            await _bot.SendTextMessageAsync(msg.Message.Chat.Id, Phrases.CreateRequest);
            await _bot.SendTextMessageAsync(msg.Message.Chat.Id, Phrases.WriteFIO, );
        }
    }
}
