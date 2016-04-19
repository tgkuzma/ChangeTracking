using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DataContext();
            var salesRepo = new Repository<SalesPerson>(context);
            var clientRepo = new Repository<Client>(context);

            var person = salesRepo.GetAll().FirstOrDefault();
            var client = clientRepo.GetAll().FirstOrDefault();

            client.SalesPerson = person;
            clientRepo.SaveChanges();

            Console.WriteLine(person.FirstName);
            Console.WriteLine(client.Name);
            var hasSales = client.SalesPerson != null;
            Console.WriteLine(hasSales);
            Console.WriteLine(person.Clients.Count);

            Console.ReadLine();
        }
    }
}
