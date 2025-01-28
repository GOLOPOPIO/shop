
namespace DataLibrary
{
    public class Customer : ITable
    {
        public int Id { get; set; }
        public required string Phone { get; set; }
        public string? VK_URL { get; set; }
        public string? TG_URL { get; set; }
        public required string Andress { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}
