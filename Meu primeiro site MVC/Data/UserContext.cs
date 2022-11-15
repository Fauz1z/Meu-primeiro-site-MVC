using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Web_App_example.Models;

namespace Web_App_example.Data
{
    public class UserContext : DbContext 
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
          
        }

        public DbSet<User>? User { get; set; }


    }
}
