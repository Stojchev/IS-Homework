namespace ISServices.Interface
{
    using ISDomain.Identity;
    using System.Collections.Generic;
    public interface IUserService
    {
        bool ChangeUserRole(string userId);
        List<CinemaApplicationUser> findAll();
        bool IsAdmin(string userId);
    }
}
