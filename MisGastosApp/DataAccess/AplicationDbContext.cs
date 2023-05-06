using Microsoft.EntityFrameworkCore;
using MisGastosApp.Entities;

namespace MisGastosApp.DataAccess
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
        public DbSet<Egresos> Egresos => Set<Egresos>();

    }
}
