using System.Collections.Generic;

namespace ImageGallery.Domain
{
    public interface IAlbumtItemService
    {
        AlbumItem GetAlbumItemByID(int id);
        List<AlbumItem> GetAlbumItems();
    }
}
