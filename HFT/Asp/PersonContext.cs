using asp05.Models;
using Microsoft.EntityFrameworkCore;

namespace asp05.Data
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Keyword> Keywords{ get; set; }
        public PersonContext(DbContextOptions<PersonContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Keyword>()
            .HasOne<Person>(e => e.person)
            .WithMany(d => d.KeyWords)
            .HasForeignKey(e => e.PId)
            .IsRequired(false);
        }
    }
}
