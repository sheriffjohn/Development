using ImageGallery.Infrastructure.Domain;
using System;

namespace ImageGallery.Domain
{
    public class Photo : ModelBase<int>
    {
        public byte[] PhotoImage { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
