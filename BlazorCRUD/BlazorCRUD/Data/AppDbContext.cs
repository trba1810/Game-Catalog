using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }


    }
}
