using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Rest;
using Models.classes;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Services.classes
{
    public class LoginHandler : IRequestHandler<LoginQuery, UserModel>
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public LoginHandler(
            UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<UserModel> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new RestException(HttpStatusCode.Unauthorized.ToString());
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (result.Succeeded)
            {
                return new UserModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Token = "test",
                    UserName = user.UserName
                };
            }

            throw new RestException(HttpStatusCode.Unauthorized.ToString());
        }
    }
}
