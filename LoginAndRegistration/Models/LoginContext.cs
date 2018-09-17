using Microsoft.EntityFrameworkCore;
 
namespace LoginAndRegistration.Models
{
    public class LoginContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public LoginContext(DbContextOptions<LoginContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}