using AutoPoco;
using AutoPoco.Engine;
using DAL;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TEST
{
    [TestClass]
    public class UnitTests
    {
        #region Entity To Dto Mapping Tests
        [TestMethod]
        public void MapTEntityToTDtoTest()
        {
            var factory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c => c.UseDefaultConventions());
                x.AddFromAssemblyContainingType<UserEntity>();
            });

            IGenerationSession session = factory.CreateSession();

            UserEntity entity = session.Single<UserEntity>()
                .Impose(x => x.FirstName, "John")
                .Impose(x => x.LastName, "Doe")
                .Get();

            MapperHelper<UserEntity, UserDto> helper = new MapperHelper<UserEntity, UserDto>();

            UserDto result = helper.MapToDto(entity);

            Assert.IsNotNull(result);
        }
        #endregion

        #region Business Logic Tests

        #endregion

    }
}


