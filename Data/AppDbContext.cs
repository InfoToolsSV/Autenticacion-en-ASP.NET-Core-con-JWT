using AuthJWT.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthJWT.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}