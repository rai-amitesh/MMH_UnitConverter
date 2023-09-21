using Conversion.API.Data;
using Conversion.API.Models.Domain;
using Conversion.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Conversion.API.Repositories.Implementation
{
    public class UnitMasterRepository : IUnitMasterRepository
    {
        private readonly ApplicationDbContext dbContext;
        public UnitMasterRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<UnitMaster> CreateAsync(UnitMaster unitmaster)
        {
            await dbContext.UnitMasters.AddAsync(unitmaster);
            await dbContext.SaveChangesAsync();

            return unitmaster;
        }

        public async Task<IEnumerable<UnitMaster>> GetAllAsync()
        {
            return await dbContext.UnitMasters.ToListAsync();
        }

        public async Task<UnitMaster> GetByUnitType(string? unittype)
        {
            return await dbContext.UnitMasters.FirstOrDefaultAsync(x => x.UnitType == unittype);
        }
    }
}
