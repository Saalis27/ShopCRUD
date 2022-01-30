using Microsoft.EntityFrameworkCore;

namespace ShopCRUD.Models
{
    public class ItemDBContext: DbContext
    {
        public ItemDBContext(DbContextOptions<ItemDBContext> options): base(options)
        {

        }

        public DbSet<Items> Items { get; set; }

    }
}
