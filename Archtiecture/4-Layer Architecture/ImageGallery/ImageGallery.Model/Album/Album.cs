using ImageGallery.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ImageGallery.Domain
{
    public class Album : ModelBase<int>//Aggregate root
    {
        private User _user;
        private List<AlbumItem> _items;
        private string _title;

        public Album(User user, string title)
        {
            _items = new List<AlbumItem>();
            _title = title;
            _user = user;
        }

        public Album(Album album)
        {
            _user = album.User;
            _items = album.AlbumItems;
            _title = album.Title;
        }

        public string Title
        {
            get { return _title; }
        }

        public User User
        {
            get { return _user; }
        }

        public int NumberOfItems
        {
            get { return _items.Count(); }
        }

        public List<AlbumItem> AlbumItems
        {
            get { return _items; }
        }

        public void AddAlbumItem(AlbumItem item)
        {
            if (DuplicatePhotoItemFor(item))
                GetItemFor(item).AddDuplicatePhotoItem();
            else
                _items.Add(item);
        }
        private bool DuplicatePhotoItemFor(AlbumItem item)
        {
            return _items.Any(p => p.Equals(item));
        }

        public AlbumItem GetItemFor(AlbumItem item)
        {
            return _items.Where(i => i.Id == item.Id).FirstOrDefault();
        }

        public List<AlbumItem> SearchItemForInfo(string searchtext)
        {
            return _items.Where(x => x.Info.Contains(searchtext)).ToList();
        }

        public List<AlbumItem> SearchItemForTag(string tag)
        {
            return _items.Where(x => x.Tag.Contains(tag)).ToList();
        }

        public void RemoveAlbumItem(AlbumItem item)
        {
            if (DuplicatePhotoItemFor(item))
            {
                _items.Remove(GetItemFor(item));
            }
        }

        public void UpdateAlbumItemInfo(AlbumItem item)
        {
            var currentItem = GetItemFor(item);
            currentItem = item;
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
