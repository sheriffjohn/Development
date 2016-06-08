using ImageGallery.Domain;
using ImageGallery.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ImageGallery.Tests
{
    [TestClass]
    public class MappingTest
    {
        private User _user;

        [TestInitialize]
        public void Init()
        {
            AutoMapperBootstrapper.Init();
            _user = new User() { Id = 1, Name = "John" };
        }

        [TestMethod]
        public void MapAlbumToAlbumEntity_WithoutAlbumItem()
        {
            Album album = new Album(_user, "TestAlbum");

            AlbumEntity entity = AutoMapper.Mapper.Map<AlbumEntity>(album);

            Assert.AreEqual(entity.UserEntity.Name, album.User.Name);
            Assert.AreEqual(entity.Title, album.Title);
        }

        [TestMethod]
        public void MapAlbumToAlbumEntity_WithAlbumItems()
        {
            Album album = new Album(_user, "TestAlbum");

            AlbumItem albumitem = new AlbumItem(new Photo(), album.User);
            albumitem.AddComment("Nice Picture");

            albumitem.Tag = new string[] { "Cool" };

            album.AddAlbumItem(albumitem);
            album.RemoveAlbumItem(albumitem);
            album.AddAlbumItem(albumitem);

            AlbumEntity entity = AutoMapper.Mapper.Map<AlbumEntity>(album);

            Assert.AreEqual(entity.UserEntity.Name, album.User.Name);
            Assert.AreEqual(entity.Title, album.Title);
            Assert.AreEqual(entity.AlbumItems.FirstOrDefault().Comments.FirstOrDefault().Comment, "Nice Picture");

            Assert.AreEqual(entity.AlbumItems.FirstOrDefault().UserEntity.Name, _user.Name);
            Assert.AreEqual(entity.AlbumItems.FirstOrDefault().Tag[0], "Cool");
        }
    }
}
