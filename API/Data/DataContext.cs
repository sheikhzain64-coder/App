using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            //Not important but if we don't add it we will get the error so better to add it. 
        }
        public DbSet<AppUser> Users { get; set; }
    }
}