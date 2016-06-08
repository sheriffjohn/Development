using ImageGallery.Domain;
using System;
using System.Collections.Generic;

namespace ImageGallery.Services.Facade
{
    public class ServiceFacade : IServiceFacade
    {
        private IUserRepository _userRepository;
        private IAlbumRepository _albumRepository;
        private IAlbumItemRepository _photoRepository;

        public ServiceFacade(IUserRepository userRepositoty, IAlbumRepository albumRepository, IAlbumItemRepository albumtItemRepository)
        {
            _userRepository = userRepositoty;
            _albumRepository = albumRepository;
            _photoRepository = albumtItemRepository;
        }

        public IEnumerable<string> GetAllAlbumId()
        {
            throw new NotImplementedException();
        }

        public bool CreateAlbum(Album album)
        {
            throw new NotImplementedException();
        }

        public AlbumItem GetAlbumItemByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AlbumItem> GetAlbumItems()
        {
            throw new NotImplementedException();
        }
    }
}
