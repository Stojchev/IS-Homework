namespace ISServices.Implementation
{
    using ISDomain.DomainModels;
    using ISRepository.Interface;
    using ISServices.Interface;
    using System.Linq;
    using System.Threading.Tasks;
    public class BackGroundEmailSender : IBackGroundEmailSender
    {
        private readonly IEmailService _emailService;
        private readonly IRepository<EmailMessage> _mailRepository;


        public BackGroundEmailSender(IEmailService emailService, IRepository<EmailMessage> mailRepository)
        {
            _emailService = emailService;
            _mailRepository = mailRepository;
        }

        public async Task DoWork()
        {
            await _emailService.SendEmailAsync(_mailRepository.GetAll().Where(z => !z.Status).ToList());
        }
    }
}
