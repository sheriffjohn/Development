using System.Collections.Generic;

namespace ImageGallery.Repository
{
    public class AlbumEntity : EntityBase
    {
        public int AlbumEntityId { get; set; }
        public string Title { get; set; }
        public UserEntity UserEntity { get; set; }
        public int UserEntity_FK { get; set; }
        public List<AlbumItemEntity> AlbumItems { get; set; }
    }
}
