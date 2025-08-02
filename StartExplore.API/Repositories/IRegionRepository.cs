using StartExploreAPI.Models.Domain;

namespace StartExplore.API.Repositories
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsync();
    }
}
