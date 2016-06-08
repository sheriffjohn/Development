using ImageGallery.Domain;
using System;
using System.Collections.Generic;

namespace ImageGallery.Repository
{
    public class AlbumItemRepository : IAlbumItemRepository
    {
        private EFDbContext _context;

        public AlbumItemRepository()
        {
            _context = new EFDbContext();
        }

        public bool Delete(AlbumItem enity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AlbumItem> Find(string text)
        {
            throw new NotImplementedException();
        }

        public AlbumItem Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(AlbumItem entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(AlbumItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
