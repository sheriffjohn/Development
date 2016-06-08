using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ImageGallery.Repository.Mapping
{
    public class AlbumEntityMap : EntityTypeConfiguration<AlbumEntity>
    {
        public AlbumEntityMap()
        {
            //Primary Key
            this.HasKey(k => k.AlbumEntityId);

            //Properties
            this.Property(p => p.AlbumEntityId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.RowId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(50);

            //One-to-Many
            this.HasMany<AlbumItemEntity>(c => c.AlbumItems)
                .WithRequired(c => c.AlbumEntity)
                .HasForeignKey(f => f.AlbumEntity_FK)
                .WillCascadeOnDelete();

            //Many-to-One
            this.HasRequired<UserEntity>(p => p.UserEntity)
                .WithMany()
                .HasForeignKey(f => f.UserEntity_FK)
                .WillCascadeOnDelete(false);


            // Table & Column Mappings
            this.ToTable("Album");
            this.Property(t => t.Title).HasColumnName("Titel");
        }
    }
}
