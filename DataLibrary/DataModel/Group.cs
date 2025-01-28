namespace DataLibrary
{
    public class Group : ITable
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
