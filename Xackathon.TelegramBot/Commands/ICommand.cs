using Telegram.Bot.Types;

namespace Xackathon.TelegramBot.Commands
{
    public interface ICommand
    {
        public bool CanExecute(Update msg);
        public Task Execute(Update msg);
    }
}
