using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class SalesPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Client> Clients { get; set; }
    }
}