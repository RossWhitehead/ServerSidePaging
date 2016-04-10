using Framework.Data;
using ServerSidePaging.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSidePaging.Data.Interfaces
{
    public interface IServerSidePagingUnitOfWork : IUnitOfWork
    {
        IRepository<Product> ProductRepository { get; }
    }
}
