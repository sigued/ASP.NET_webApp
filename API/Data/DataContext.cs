using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        
        // Attribut avec la classe avec laquelle nous voulons creer le data set (permet de creer la table Users dans la db)
        public DbSet<AppUser> Users { get; set; }
    }
}