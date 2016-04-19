using System.Data.Entity;

namespace ConsoleApplication1
{
    public class DataContext : DbContext
    {
        public DataContext() : base("MyContext")
        {
            Database.SetInitializer(new DataContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Client>()
            //    .HasOptional(s => s.SalesPerson);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<SalesPerson> SalesPeople { get; set; }
    }
}