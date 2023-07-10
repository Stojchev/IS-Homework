namespace ISServices.Interface
{
    using ISDomain.DomainModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmailService
    {
        Task SendEmailAsync(List<EmailMessage> allMails);
    }
}
