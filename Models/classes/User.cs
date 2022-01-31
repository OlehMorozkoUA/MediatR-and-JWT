using Microsoft.AspNetCore.Identity;

namespace Models.classes
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
