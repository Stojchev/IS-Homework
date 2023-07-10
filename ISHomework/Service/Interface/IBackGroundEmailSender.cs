namespace ISServices.Interface
{
    using System.Threading.Tasks;

    public interface IBackGroundEmailSender
    {
        Task DoWork();
    }
}
