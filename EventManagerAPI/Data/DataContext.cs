using EventManagerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventManagerAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users")
                .HasKey(usr => new {usr.Id});
            modelBuilder.Entity<Event>().ToTable("Events")
                .HasKey(ev => new {ev.Id, ev.IdUser });
            modelBuilder.Entity<Member>().ToTable("Members")
                .HasKey(me => new { me.Id,me.idEvent,me.idUser});
        }
    }
}
