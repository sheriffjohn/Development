using ImageGallery.Domain;
using ImageGallery.Repository;
using ImageGallery.Repository.Repositories;
using ImageGallery.Services.Facade;
using ImageGallery.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;



namespace ImageGallery.Tests.Controllers
{
    [TestClass]
    public class WebAPiControllerTest
    {
        [TestInitialize]
        public void Init()
        {
            AutoMapperBootstrapper.Init();
        }

        [TestMethod]
        public void PostTest_StatusCodeOk()
        {
            User user = new User() { Id = 1, Name = "John" };
            string title = "TestAlbum";


            var serviceMock = new Mock<IServiceFacade>();
            serviceMock.Setup(m => m.CreateAlbum(It.IsAny<Album>())).Returns(true);

            var repositoryMock = new Mock<IAlbumRepository>();
            repositoryMock.Setup(m => m.Save(It.IsAny<Album>()));

            // Arrange
            AlbumController controller = new AlbumController(serviceMock.Object);

            // Act

            // Assert            
        }

        #region

        [TestMethod]
        public void PostTest_CanSave()
        {
            //Arrange

            var mockSet = new Mock<DbSet<AlbumEntity>>();

            var mockContext = new Mock<EFDbContext>();
            mockContext.Setup(m => m.Albums).Returns(mockSet.Object);

            var repository = new AlbumRepository(mockContext.Object);

            User user = new User() { Id = 1, Name = "John" };
            string title = "TestAlbum";

            Album album = new Album(user, title);

            //Act
            var result = repository.Save(album);

            //Assert
            Assert.IsTrue(result);
        }

        #endregion
    }
}
