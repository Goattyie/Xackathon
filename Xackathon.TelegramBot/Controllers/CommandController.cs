using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace Xackathon.TelegramBot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly CommandHandler _handler;

        public CommandController(CommandHandler handler)
        {
            _handler = handler;
        }
        [HttpPost]
        public async Task Update([FromBody]Update msg)
        {
            await _handler.Handle(msg);
        }
        [HttpGet]
        public IActionResult Get() => Ok("Ok");
    }
}
