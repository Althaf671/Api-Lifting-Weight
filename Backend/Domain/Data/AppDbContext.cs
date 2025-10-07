/**
 * AppDbContext.cs adalah file yang menjadi
 * gateway antara file entities dan repositories
 * dengan ORM entities yang berguna untuk 
 * berkomunikasi dengan database.
 */
using Microsoft.EntityFrameworkCore;


namespace Backend.Domain.Data
{
    // Class Application Database Context
    public class AppDbContext(DbContextOptions<AppDbContext> options) 
        : DbContext(options)
    {
    }
}