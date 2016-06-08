using System;

namespace ImageGallery.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void CommitTransaction();
        void StartTransaction();
    }
}
