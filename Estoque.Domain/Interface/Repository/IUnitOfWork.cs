using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Domain.Interface.Repository
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
