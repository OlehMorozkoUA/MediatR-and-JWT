using DataAccess;
using Microsoft.AspNetCore.Identity;
using Models.classes;
using Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.classes
{
    public class UserRepository : IUserRepository
    {
        public readonly JWTDbContext _jWTDbContext;
        private readonly UserManager<User> _userManager;

        public UserRepository(
            JWTDbContext jWTDbContext,
            UserManager<User> userManager)
        {
            _jWTDbContext = jWTDbContext;
            _userManager = userManager;
        }

        public async Task UserSeedAsync()
        {
            await DataAccess.DataSeed.SeedDataAsync(_jWTDbContext, _userManager);
        }
    }
}
