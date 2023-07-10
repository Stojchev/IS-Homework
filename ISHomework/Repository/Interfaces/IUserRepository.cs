namespace ISRepository.Interface
{
    using ISDomain.Identity;
    using System.Collections.Generic;
    public interface IUserRepository
    {
        IEnumerable<CinemaApplicationUser> GetAll();
        CinemaApplicationUser Get(string id);
        void Insert(CinemaApplicationUser entity);
        void Update(CinemaApplicationUser entity);
        void Delete(CinemaApplicationUser entity);
    }
}
