namespace ConsoleApplication1
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
    }
}