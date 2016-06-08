namespace ImageGallery.Repository
{
    public class PhotoCommentEntity
    {
        public int PhotoCommentEntityId { get; set; }
        public UserEntity User { get; set; }
        public string Comment { get; set; }
    }
}