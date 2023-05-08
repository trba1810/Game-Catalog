using BlazorCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BlazorCRUD.Services
{
    public class GameCatalogService
    {
        private IDbContextFactory<AppDbContext> _dbContextFactory;


        public GameCatalogService(IDbContextFactory<AppDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void AddGame(GameModel game)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Games.Add(game);
                context.SaveChanges();
            }
        }

        public List<GameModel> GetGames()
        {
            using(var context = _dbContextFactory.CreateDbContext())
            {
                return context.Games.ToList();
            }
        }
    }
}
