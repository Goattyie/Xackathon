using Telegram.Bot;
using Telegram.Bot.Types;
using Xackathon.TelegramBot.Commands;

namespace Xackathon.TelegramBot
{
    public class CommandHandler
    {
        private readonly ITelegramBotClient _bot;
        private readonly IEnumerable<ICommand> _commands;

        public CommandHandler(IEnumerable<ICommand> commands, ITelegramBotClient bot)
        {
            _bot = bot;
            _commands = commands;
        }
        public async Task Handle(Update msg)
        {
            var command = _commands.FirstOrDefault(x=>x.CanExecute(msg));

            if (command == null)
            {
                await _bot.SendTextMessageAsync(msg.Message.Chat.Id, "Команда не найдена");
                return;
            }

            await command.Execute(msg);
        }
    }
}
