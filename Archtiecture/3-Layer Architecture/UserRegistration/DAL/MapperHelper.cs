using AutoMapper;
using DTO;

namespace DAL
{
    public class MapperHelper<TEntity, TDto>
        where TEntity : new()
        where TDto : new()
    {
        private readonly MapperConfiguration _config;

        public MapperHelper()
        {
            _config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDto, UserEntity>();
                cfg.CreateMap<UserEntity, UserDto>();
            });
        }

        public TDto MapToDto(TEntity source)
        {
            IMapper mapper = _config.CreateMapper();
            return mapper.Map<TEntity, TDto>(source); ;
        }
    }
}
