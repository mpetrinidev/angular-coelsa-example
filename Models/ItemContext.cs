using Microsoft.EntityFrameworkCore;

namespace angular_coelsa_example.Models
{
    public class ItemContext : DbContext
    {
        public DbSet<ToDo> ToDo { get; set; }

        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}