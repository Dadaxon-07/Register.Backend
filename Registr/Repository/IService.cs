using Register.Backend.Model;

namespace Register.Backend.Repository
{
    public interface IService
    {
        Task<bool> SigUpAsync(User user);
        Task<bool> LogIn(string email, string password );
    }
}
