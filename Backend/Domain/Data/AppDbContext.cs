/**
 * AppDbContext.cs adalah file yang menjadi
 * gateway antara file entities dan repositories
 * dengan ORM entities yang berguna untuk 
 * berkomunikasi dengan database.
 */
using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Backend.Domain.Data
{
    // Class Application Database Context
    public class AppDbContext(DbContextOptions<AppDbContext> options)
        : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<RefreshSession> RefreshSessions { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Abusive> Abusives { get; set; }
    }
}