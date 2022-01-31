using System.Threading.Tasks;

namespace Repositories.interfaces
{
    public interface IUserRepository
    {
        Task UserSeedAsync();
    }
}
