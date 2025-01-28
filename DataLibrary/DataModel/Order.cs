namespace DataLibrary
{
    public class Order : ITable
    {
        public int Id { get; set; }
        public float Sum { get; set; }
        public byte Status { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
    