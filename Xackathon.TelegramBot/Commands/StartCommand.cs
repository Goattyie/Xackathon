using Telegram.Bot;
using Telegram.Bot.Types;
using Xackathon.TelegramBot.Resources;

namespace Xackathon.TelegramBot.Commands
{
    public class StartCommand : ICommand
    {
        private readonly ITelegramBotClient _bot;

        public StartCommand(ITelegramBotClient bot)
        {
            _bot = bot;
        }
        public bool CanExecute(Update msg) => msg?.Message?.Text == "/start";

        public async Task Execute(Update msg)
        {
            await _bot.SendTextMessageAsync(msg.Message.Chat.Id, Phrases.Instructions);
        }
    }
}
