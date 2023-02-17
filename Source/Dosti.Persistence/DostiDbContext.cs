using Dosti.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dosti.Persistence
{

    public class DostiDbContext : DbContext
    {
        public DbSet<DostiUser> Users => Set<DostiUser>();

        public DostiDbContext(DbContextOptions<DostiDbContext> options) : base(options)
        {
        }
    }

}
