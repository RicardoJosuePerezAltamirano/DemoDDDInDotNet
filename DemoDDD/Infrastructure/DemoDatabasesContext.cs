using Microsoft.EntityFrameworkCore;

namespace DemoDDD.Infrastructure
{
    public class DemoDatabasesContext:DbContext
    {
        public DemoDatabasesContext(DbContextOptions<DemoDatabasesContext> options):base(options)
        {
            
        }
        public DbSet<Domain.Entities.Person> Person { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Person>(o =>
            {
                o.HasKey(x => x.Id);
                
            });
            modelBuilder.Entity<Domain.Entities.Person>().OwnsOne(o => o.Name);
            base.OnModelCreating(modelBuilder); 
        }
    }
}
