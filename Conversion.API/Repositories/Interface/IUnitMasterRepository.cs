using Conversion.API.Models.Domain;

namespace Conversion.API.Repositories.Interface
{
    public interface IUnitMasterRepository
    {
        Task<UnitMaster> CreateAsync(UnitMaster unitmaster);
        Task<IEnumerable<UnitMaster>> GetAllAsync();

        Task<UnitMaster> GetByUnitType(string unittype);
    }
}
