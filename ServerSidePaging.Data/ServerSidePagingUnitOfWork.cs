using Framework.Data;
using ServerSidePaging.Data.Interfaces;
using ServerSidePaging.Model;
using System;

namespace ServerSidePaging.Data
{
    public class ServerSidePagingUnitOfWork : IServerSidePagingUnitOfWork, IDisposable
    {
        private ServerSidePagingDbContext _db = new ServerSidePagingDbContext();

        private EFRepository<Product> _productRepository;

        public IRepository<Product> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new EFRepository<Product>(_db);
                return _productRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}