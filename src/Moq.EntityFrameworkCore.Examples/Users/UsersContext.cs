namespace Moq.EntityFrameworkCore.Examples.Users
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Moq.EntityFrameworkCore.Examples.Users.Entities;

    public class UsersContext : IdentityDbContext
    {
        public virtual DbSet<User> MockUsers { get; set; }

        public virtual DbSet<Role> MockRoles { get; set; }
    }
}