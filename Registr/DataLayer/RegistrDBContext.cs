using Microsoft.EntityFrameworkCore;
using Register.Backend.Model;

namespace Register.Backend.DataLayer
{
    public class RegistrDbContext:DbContext
    {
        public RegistrDbContext(DbContextOptions<RegistrDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<User>MyProperty { get; set; }

        

    }
}
