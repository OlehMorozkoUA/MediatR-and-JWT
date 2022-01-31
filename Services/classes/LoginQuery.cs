using MediatR;
using Models.classes;

namespace Services.classes
{
    public class LoginQuery : IRequest<UserModel>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
