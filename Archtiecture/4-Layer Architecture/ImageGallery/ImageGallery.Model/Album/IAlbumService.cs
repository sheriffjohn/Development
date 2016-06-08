using System.Collections.Generic;

namespace ImageGallery.Domain
{
    public interface IAlbumService
    {
        IEnumerable<string> GetAllAlbumId();

        bool CreateAlbum(Album album);
    }
}
