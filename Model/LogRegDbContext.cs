using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginRegistration.Model
{
    public class LogRegDbContext : IdentityDbContext
    {
        public LogRegDbContext(DbContextOptions<LogRegDbContext> options): base(options)
        {
            
        }
    }
}
