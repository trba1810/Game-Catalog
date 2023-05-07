using BlazorCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

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
    }
}
