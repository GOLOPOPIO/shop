namespace DataLibrary
{
    public class Product : ITable
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Price { get; set; }
        public bool Avaliably {  get; set; }
        public DateTime CreationTime { get; set; }
        public List<Group> Groups { get; set; } = new();
        public List<Recipte> Recipts { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
    }
}
