using Impar.BackEnd.Evaluation.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Impar.BackEnd.Evaluation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessagesService _messagesService;
        private readonly ILogger<MessagesController> _logger;
        public MessagesController(IMessagesService messagesService, ILogger<MessagesController> logger)
        {
            _messagesService = messagesService;
            _logger = logger;
        }

        [HttpGet]
        [Route("status")]
        public IActionResult Status()
        {
            return Ok("Mostre o status do envio aqui");
        }


        [HttpPost]
        [Route("send")]
        public IActionResult SendMessages()
        {
            bool response = _messagesService.SendMessages();
            if (response)
            {
                return Ok("Mensagens enviadas com sucesso.");
            }
            else
            {
                _logger.LogError("Erro durante o envio de mensagens.");
                return StatusCode(500, "Erro durante o envio de mensagens.");
            }
        }
    }
}
