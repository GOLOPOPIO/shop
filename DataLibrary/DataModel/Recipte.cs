namespace DataLibrary
{
    public class Recipte : ITable
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}