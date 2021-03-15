using Estoque.Domain.Interface.Repository;
using Estoque.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProdutoContext _produtoContext;

        public UnitOfWork(ProdutoContext produtoContext)
        {
            _produtoContext = produtoContext;
        }

        public void Commit()
        {
            _produtoContext.SaveChanges();
        }
    }
}
