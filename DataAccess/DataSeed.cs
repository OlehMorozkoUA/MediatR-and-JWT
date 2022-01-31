using Microsoft.AspNetCore.Identity;
using Models.classes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataSeed
    {
        public static async Task SeedDataAsync(JWTDbContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<User>
                                {
                                    new User
                                        {
                                            FirstName = "FirstName1",
                                            LastName = "LastName1",
                                            UserName = "TestUserFirst",
                                            Email = "testuserfirst@test.com"
                                        },

                                    new User
                                        {
                                            FirstName = "FirstName2",
                                            LastName = "LastName2",
                                            UserName = "TestUserSecond",
                                            Email = "testusersecond@test.com"
                                        }
                                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "qazwsX123@");
                }
            }
        }
    }
}
