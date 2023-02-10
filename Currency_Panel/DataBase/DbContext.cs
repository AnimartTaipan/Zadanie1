using System.Data.Entity;

namespace Currency_Panel.DataBase
{
    public class FavouritesDbContext : DbContext
    {
        public DbSet<Favourite> Favourites { get; set; }
    }
}
