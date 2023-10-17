using Impar.BackEnd.Evaluation.Contexts;
using Impar.BackEnd.Evaluation.Entities;

namespace Impar.BackEnd.Evaluation.Services
{
    public class MessagesService: IMessagesService
    {
        private readonly MessagesDbContext _dbContext;
        public MessagesService(MessagesDbContext ctx)
        {
            _dbContext = ctx;
        }

        public bool SendMessages()
        {
            // Obtem os usuários
            List<User> users = _dbContext.Users.ToList();

            // Manda as mensagens
            foreach (User user in users)
            {
                // Não precisa fazer o envio de fato, este Thread.Sleep
                // apenas simula o tempo gasto no envio
                Thread.Sleep(500);

                // Salva no banco a mensagem enviada
                _dbContext.Messages.Add(new Message
                {
                    MessageContent = $"Esta é uma mensagem enviada para {user.Name} ({user.Email})",
                    SentAt = DateTime.UtcNow,
                    Subject = $"User: {user.Name}",
                    UserId = user.Id
                });
            }

            int savedRows = _dbContext.SaveChanges();

            if (savedRows > 0) 
            {
                return true;
            } else 
            { 
                return false; 
            }
        }
    }
}