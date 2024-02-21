using BookOrganiserWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookOrganiserWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
