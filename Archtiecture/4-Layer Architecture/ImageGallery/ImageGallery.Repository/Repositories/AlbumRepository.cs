using ImageGallery.Domain;
using System;
using System.Collections.Generic;

namespace ImageGallery.Repository.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        private EFDbContext _context;

        public AlbumRepository(EFDbContext context)
        {
            _context = context;
        }

        public bool Delete(Album model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Album> Find(string text)
        {
            throw new NotImplementedException();
        }

        public Album Get(int id)
        {
            throw new NotImplementedException();
        }

        public Album GetAlbumById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Album> GetAllAlbums()
        {
            throw new NotImplementedException();
        }

        public bool Save(Album model)
        {
            var entity = AutoMapper.Mapper.Map<AlbumEntity>(model);

            if (entity != null)
            {
                _context.Albums.Add(entity);
                _context.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(Album model)
        {
            throw new NotImplementedException();
        }
    }
}
