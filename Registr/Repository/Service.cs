using Microsoft.EntityFrameworkCore;
using Register.Backend.DataLayer;
using Register.Backend.Model;

namespace Register.Backend.Repository
{
    public class Service : IService
    {
        private readonly RegistrDbContext _registr;

        public Service(RegistrDbContext registr)
        {
            _registr = registr; 
        }
      public async  Task<bool> IService.LogIn(string email, string password)
        {
          var res = await _registr.Users.FirstOrDefaultAsync(p => p.EmailAddress == email && p.Password == password );
            if(res == null)
            {
                return false;
            }
            return true;
        }

     public async Task<bool> IService.SignUpAsync(User user)
        {
          if(user != null ) 
            {
              await  _registr.AddAsync(user);
                _registr.SaveChanges();
                return true;
            }
            return false;
        

        }
    }
}
