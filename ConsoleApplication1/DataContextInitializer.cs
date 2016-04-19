using System.Data.Entity;

namespace ConsoleApplication1
{
    //internal class DataContextInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    internal class DataContextInitializer : DropCreateDatabaseAlways<DataContext>
    {
        private static DataContext _context;

        protected override void Seed(DataContext context)
        {
            _context = context;
            SeedSalesPerson();
            SeedClient();
        }

        private void SeedClient()
        {
            _context.Clients.Add(new Client
            {
                Name = "My New Client"
            });
        }

        private static void SeedSalesPerson()
        {
            _context.SalesPeople.Add(new SalesPerson
            {
                FirstName = "Trenton",
                LastName = "Kuzma"
            });

            _context.SaveChanges();
        }
    }
}