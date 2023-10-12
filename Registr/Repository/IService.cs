using Register.Backend.Model;

namespace Register.Backend.Repository
{
    public interface IService
    {
        Task<bool> SignUpAsync(User user);
        Task<bool> LogIn(string email, string password );
    }
}
