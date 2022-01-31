using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.classes;

namespace DataAccess
{
    public class JWTDbContext : IdentityDbContext<User, Role, int>
    {
        //public JWTDbContext(DbContextOptions<JWTDbContext> options) : base(options)
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=.\sqlexpress;Initial Catalog=JWT;Integrated Security=True;");
        }
    }
}
