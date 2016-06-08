namespace ImageGallery.Data
{
    class Program
    {
        //        static readonly string localPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        //        static void Main(string[] args)
        //        {
        //            ////AppDomain.CurrentDomain.SetData("DataDirectory", localPath); //Console applications need DataDirectory to be specified
        //            //Console.WriteLine("Initializing Entities");

        //            //AlbumFactory factory = new AlbumFactory();

        //            //User user = new User() { Name = "John" };
        //            //Album album = factory.Create(user, "New Album");


        //            //PhotoComment comment1 = new PhotoComment() { Comment = "Looking good", User = user };
        //            //PhotoComment comment2 = new PhotoComment() { Comment = "Nice picture", User = user };

        //            //List<PhotoComment> comments = new List<PhotoComment>();
        //            //comments.Add(comment1);
        //            //comments.Add(comment2);

        //            //Photo photo = new Photo() { Tag = new string[] { "Cool", "Outdoor" } };
        //            //Photo photo2 = new Photo() { Tag = new string[] { "Not cool", "Indoor" } };

        //            //AlbumItem item = new AlbumItem(photo, user) { Id = 1, Comments = comments, Info = "Some picture I took", Country = "Sweden", Coordinate = 19.10, Location = "Göteborg" };
        //            //AlbumItem item2 = new AlbumItem(photo2, user) { Id = 2, Comments = comments, Info = "Some other picture I took", Country = "Sweden", Coordinate = 11.10, Location = "Stockholm" };

        //            //AlbumEntity e1 = new AlbumEntity() { Title = "hepp" };

        //            album.AddAlbumItem(item);
        //            album.AddAlbumItem(item2);


        //            var entity = AutoMapper.Mapper.Map<AlbumEntity>(album);

        //            using (var context = new EFDbContext())
        //            {
        //                context.Albums.Add(entity);
        //                context.SaveChanges();
        //                var existingalbum = context.Albums.FirstOrDefault();
        //                //context.Albums.Remove(f);
        //                //context.SaveChanges();
        //            }

        //            Console.WriteLine("Initialize finished");

        //            Console.ReadLine();
        //        }
    }
}
