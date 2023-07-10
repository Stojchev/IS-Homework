namespace ISDomain.Identity
{
    using ISDomain.DomainModels;
    using ISDomain.Identity.Enum;
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    public class CinemaApplicationUser : IdentityUser
    {
        public Role Role { get; set; } = Role.ROLE_USER;
        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
