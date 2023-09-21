using Conversion.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Conversion.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<UnitMaster> UnitMasters { get; set; }
    }
}
