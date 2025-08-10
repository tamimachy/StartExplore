using StartExplore.API.Models.Domain;

namespace StartExplore.API.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
