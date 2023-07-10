namespace ISServices.Implementation
{
    using ISDomain.Identity;
    using ISDomain.Identity.Enum;
    using ISRepository.Interface;
    using ISServices.Interface;
    using System;
    using System.Collections.Generic;
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool ChangeUserRole(string userId)
        {
            throw new NotImplementedException();
        }

        public List<CinemaApplicationUser> findAll()
        {
            return (List<CinemaApplicationUser>)_userRepository.GetAll();
        }

        public bool IsAdmin(string userId)
        {
            CinemaApplicationUser user = _userRepository.Get(userId);
            if (user.Role == Role.ROLE_ADMIN) return true;
            return false;
        }
    }
}
