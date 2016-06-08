using ImageGallery.Repository.Mapping;
using System.Data.Entity;

namespace ImageGallery.Repository
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("EFDbConnectionString")
        {
            Database.SetInitializer<EFDbContext>(new EFDbInitializer());
            Configuration.LazyLoadingEnabled = true;
        }
        public virtual DbSet<AlbumEntity> Albums { get; set; }
        public virtual DbSet<AlbumItemEntity> AlbumItems { get; set; }
        public virtual DbSet<PhotoEntity> Photos { get; set; }
        public virtual DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumEntityMap());
            modelBuilder.Configurations.Add(new AlbumItemEntityMap());
            modelBuilder.Configurations.Add(new UserEntityMap());
        }
    }
    public class EFDbInitializer : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
        }
    }
}
