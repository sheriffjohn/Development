using AutoMapper;
using ImageGallery.Domain;
using ImageGallery.Repository;
using ImageGallery.Web.Models;

namespace ImageGallery.Tests
{
    public static class AutoMapperBootstrapper
    {
        public static void Init()
        {
            Mapper.CreateMap<Album, AlbumEntity>().ForMember(dest => dest.UserEntity, opt => opt.MapFrom(src => src.User));

            Mapper.CreateMap<AlbumViewModel, AlbumDto>();

            Mapper.CreateMap<User, UserEntity>();

            Mapper.CreateMap<AlbumItem, AlbumItemEntity>();

            Mapper.CreateMap<PhotoComment, PhotoCommentEntity>();

            Mapper.CreateMap<Photo, PhotoEntity>();

        }
    }
}
