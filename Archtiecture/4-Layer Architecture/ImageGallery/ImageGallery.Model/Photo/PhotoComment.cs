using ImageGallery.Infrastructure.Domain;
using System;

namespace ImageGallery.Domain
{
    public class PhotoComment : ModelBase<int>
    {
        private User _user;
        private string _comment;

        public PhotoComment(User user, string comment)
        {
            _user = user;
            _comment = comment;
        }

        public User User { get { return _user; } }

        public string Comment { get { return _comment; } }
        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
