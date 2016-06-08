using System;
using System.Collections.Generic;

namespace ImageGallery.Repository
{
    public class AlbumItemEntity : EntityBase
    {
        public int AlbumItemEntityId { get; set; }

        public PhotoEntity Photo { get; set; }

        public UserEntity UserEntity { get; set; }

        public string[] Tag { get; set; }

        public int UserEntity_FK { get; set; }

        public string Info { get; set; }

        public List<PhotoCommentEntity> Comments { get; set; }

        public DateTime CaptureDate { get; set; }

        public int AlbumEntity_FK { get; set; }

        public virtual AlbumEntity AlbumEntity { get; set; }

        public double Coordinate { get; set; }

        public string Location { get; set; }

        public string Country { get; set; }
    }
}