using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Panel.DataBase
{
    public class FavoritesCurrency
    {
        private FavouritesDbContext _context;

        public FavoritesCurrency()
        {
            _context = new FavouritesDbContext();
        }

        public IQueryable<Favourite> GetFavourites()
        {
            return _context.Favourites.AsNoTracking();
        }

        public void AddFavourite(string idFavourite)
        {
            Favourite favourite = new Favourite { FavouriteId = idFavourite };
            _context.Favourites.Add(favourite);
            _context.SaveChanges();
            _context.Entry(favourite).State = EntityState.Detached;
        }


        public void DeleteFavoutire(string idFavourite)
        {
            Favourite favourite = new Favourite { FavouriteId = idFavourite };
            _context.Favourites.Attach(favourite);
            _context.Favourites.Remove(favourite);
            _context.SaveChanges();
        }

        public bool IsFavoutire(string idFavourite)
        {
            var isFavoutire = _context.Favourites.AsNoTracking().FirstOrDefault(x => x.FavouriteId == idFavourite);
            if (isFavoutire != null)
                return true;

            return false;
        }

    }
}
