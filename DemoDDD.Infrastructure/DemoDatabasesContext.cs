using Microsoft.EntityFrameworkCore;

namespace DemoDDD.Infrastructure
{
    public class DemoDatabasesContext:DbContext
    {
        public DemoDatabasesContext(DbContextOptions<DemoDatabasesContext> options):base(options)
        {
            
        }
        public DbSet<Domain.Entities.Person> Persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Person>(o =>
            {
                o.HasKey(x => x.Id);
                
            });
           
            modelBuilder.Entity<Domain.Entities.Person>().OwnsOne(o => o.Name, add =>
            {
                add.Property(x=>x.Value).HasColumnName("Name");
            });
            base.OnModelCreating(modelBuilder); 
        }
    }
}
