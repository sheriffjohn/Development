using ImageGallery.Infrastructure.Domain;
using ImageGallery.Infrastructure.Helpers;
using System;
using System.Collections.Generic;

namespace ImageGallery.Domain
{
    public class AlbumItem : ModelBase<int>
    {
        private Photo _photo;
        private User _user;
        private List<PhotoComment> _comments;
        private int _duplicate;

        public AlbumItem(Photo photo, User user)
        {
            _photo = photo;
            _user = user;
            _comments = new List<PhotoComment>();
        }

        public AlbumItem(AlbumItem albumitem)
        {
            _user = albumitem.UserEntity;
            _photo = albumitem.Photo;
            _comments = albumitem.Comments;
        }

        public Photo Photo { get { return _photo; } }

        public User UserEntity { get { return _user; } }

        public string Info { get; set; }

        public string[] Tag { get; set; }

        public List<PhotoComment> Comments { get { return _comments; } }

        //public DateTime CaptureDate { get; set; }

        public double Coordinate { get; set; }

        public string Location { get; set; }

        public string Country { get; set; }

        public int Dublicate { get { return _duplicate; } }

        public string ImageSize
        {
            get { return _photo.PhotoImage.Length.ToPrettySize(); }
        }

        public void AddComment(string comment)
        {
            PhotoComment photocomment = new PhotoComment(_user, comment);
            _comments.Add(photocomment);
        }
        public void AddDuplicatePhotoItem()
        {
            _duplicate++;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }

}
