using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ImageGallery.Repository.Mapping
{
    public class AlbumItemEntityMap : EntityTypeConfiguration<AlbumItemEntity>
    {
        public AlbumItemEntityMap()
        {
            //Primary Key
            this.HasKey(k => k.AlbumItemEntityId);

            //Properties
            this.Property(p => p.AlbumItemEntityId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.RowId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Many-to-One
            this.HasRequired<UserEntity>(p => p.UserEntity)
                .WithMany()
                .HasForeignKey(f => f.UserEntity_FK)
                .WillCascadeOnDelete(false);

            this.Property(p => p.Location)
               .IsRequired()
               .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AlbumItem");
            this.Property(t => t.Info).HasColumnName("Information");
        }
    }
}
