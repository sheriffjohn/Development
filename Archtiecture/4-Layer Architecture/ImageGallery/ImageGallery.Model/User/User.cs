using ImageGallery.Infrastructure.Domain;
using System;

namespace ImageGallery.Domain
{
    public class User : ModelBase<int>
    {
        public string Name { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
