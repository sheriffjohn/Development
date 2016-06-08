using ImageGallery.Infrastructure.Domain;

namespace ImageGallery.Domain
{
    public interface IAlbumItemRepository : IRepository<AlbumItem, int>
    {
    }
}
