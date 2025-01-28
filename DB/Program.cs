using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(var db = new ShopContext())
            {
                db.Database.Migrate();
            }
        }
    }
}
