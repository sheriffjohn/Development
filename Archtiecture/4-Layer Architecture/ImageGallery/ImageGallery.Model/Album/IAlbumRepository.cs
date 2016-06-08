using ImageGallery.Infrastructure.Domain;
using System.Collections.Generic;

namespace ImageGallery.Domain
{
    public interface IAlbumRepository : IRepository<Album, int>
    {
        Album GetAlbumById(int id);

        IList<Album> GetAllAlbums();
    }
}
