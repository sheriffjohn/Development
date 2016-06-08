using ImageGallery.Infrastructure.Domain;
using System;
using System.Collections.Generic;

namespace ImageGallery.Domain
{
    public class IUserRepository : IRepository<User, int>
    {
        public bool Delete(User model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Find(string text)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(User model)
        {
            throw new NotImplementedException();
        }

        public bool Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
