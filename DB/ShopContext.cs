using Microsoft.EntityFrameworkCore;
using DataLibrary;
using System.Linq;

namespace DB
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Recipte> Reciptes => Set<Recipte>();
        public DbSet<Group> Groups => Set<Group>();

        private string connection = "DBContext.db";

        public ShopContext()
        {
            Console.WriteLine("DBContext is start");
            Console.WriteLine("Connection string\n" + new string(' ', 15) + connection);

            if (Database.EnsureCreated())
                Console.WriteLine("DB is created");
            else
            {
                Console.WriteLine("Delete DataBase? (y/n - def is n)");
                var a = Console.ReadLine();
                if (a == "y" || a == "Y")
                    Console.WriteLine("DB is deleted --- " + Database.EnsureDeleted().ToString());
            }

            Console.WriteLine(GetInfo());
            Console.WriteLine("Can connect --- " + Database.CanConnect().ToString());
            Console.WriteLine("DBContext is end");
        }
        public string GetInfo()
        {
            var tables = Model.GetEntityTypes();

            string ret = string.Empty;
            ret += new string('=', 15);
            ret += '\n';

            int count = 0;
            foreach (var t in tables)
            {
                ret += t.Name + '\n';
                count++;
            }

            ret += new string('-', 15) + '\n';
            ret += "Total --- " + count.ToString() + '\n';
            ret += new string('=', 15) + '\n';

            return ret;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            UseSQLite(optionsBuilder, "DBContext.db");

            optionsBuilder.LogTo(Console.WriteLine);
        }

        private void UseSQLite(DbContextOptionsBuilder optionsBuilder, string url)
        {
            optionsBuilder.UseSqlite("Filename=" + url);//kjhgfc
        }
    }
}
